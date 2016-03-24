using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BatchModel.Models;
using Difi.SikkerDigitalPost.Klient;
using Difi.SikkerDigitalPost.Klient.Api;
using Difi.SikkerDigitalPost.Klient.Domene.Entiteter.Aktører;
using Difi.SikkerDigitalPost.Klient.Domene.Entiteter.FysiskPost;
using Difi.SikkerDigitalPost.Klient.Domene.Entiteter.Kvitteringer;
using Difi.SikkerDigitalPost.Klient.Domene.Entiteter.Kvitteringer.Forretning;
using Difi.SikkerDigitalPost.Klient.Domene.Entiteter.Kvitteringer.Transport;
using Difi.SikkerDigitalPost.Klient.Domene.Entiteter.Post;
using Difi.SikkerDigitalPost.Klient.Domene.Enums;
using Difi.SikkerDigitalPost.Klient.XmlValidering;
using Person = BatchModel.Models.Person;

namespace SikkerDigitalPostProxy
{
    public class Client
    {
        private const string MpcId = "batchmpcId";

        public Client(string returNavn, string returPostnummer, string returPoststed, string orgNumberProcessor,
            string thumbprintProcessor)
        {
            ReturNavn = returNavn;
            ReturPostNummer = returPostnummer;
            ReturPoststed = returPoststed;
            var klientkonfigurasjon = new Klientkonfigurasjon(Miljø.FunksjoneltTestmiljø);
            InitializeLog(klientkonfigurasjon);
            SDPClient =
                new SikkerDigitalPostKlient(new Databehandler(orgNumberProcessor, thumbprintProcessor),
                    klientkonfigurasjon);
        }

        private SikkerDigitalPostKlient SDPClient { get; }
        public static string ReturNavn { get; set; }

        public static string ReturPostNummer { get; set; }

        public static string ReturPoststed { get; set; }

        public async Task<Person> Send(Person person)
        {
            var senderIdentification = "Posten Norge";
            PostInfo postInfo = null;
            if (!person.ReservedForDigitallyDelivery)
            {
                postInfo =
                    new DigitalPostInfo(
                        new DigitalPostMottaker(person.SocialSecurityNumber, person.SikkerDigitalPostAdresse,
                            person.Certificate, person.RecieverProcessorAccountNumber),
                        person.Subject);
            }
            else
            {
                Adresse adresse;
                if (person.Country == "NORGE" || person.Country == "NORWAY")
                {
                    adresse = new NorskAdresse(person.PostalNumber, person.PostalPlace);
                }
                else
                {
                    adresse = new UtenlandskAdresse(person.Country, person.AddressLine1);
                }
                var fysiskPostMottaker = new FysiskPostMottaker(person.FullName, adresse, person.Certificate,
                    person.RecieverProcessorAccountNumber);
                postInfo = new FysiskPostInfo(fysiskPostMottaker, Posttype.B, Utskriftsfarge.SortHvitt,
                    Posthåndtering.DirekteRetur,
                    new FysiskPostReturmottaker(ReturNavn, new NorskAdresse(ReturPostNummer, ReturPoststed)));
            }

            var fileData = File.ReadAllBytes(person.FilePathAndFileName);
            var file = new FileInfo(person.FilePathAndFileName);

            var mimeType = "";
            switch (file.Extension)
            {
                case "pdf":
                    mimeType = "application/pdf";
                    break;
                case "txt":
                    mimeType = "plain/txt";
                    break;
            }

            var dokumentPakke = new Dokumentpakke(new Dokument(person.Subject, fileData, mimeType, "NO", file.Name));


            var avsender = new Avsender(person.RecieverProcessorAccountNumber)
            {
                Avsenderidentifikator = senderIdentification
            };

            var forsendelse = new Forsendelse(avsender, postInfo, dokumentPakke, Prioritet.Normal, MpcId);


            Kvittering transportkvittering = null;
            try
            {
                transportkvittering = await SDPClient.SendAsync(forsendelse);
            }
            catch (Exception exception)
            {
                person.BatchStatus = BatchStatus.ERROR;
                person.StatusMessage = exception.InnerException?.Message ?? exception.Message;
                return person;
            }


            if (transportkvittering.GetType() == typeof (TransportOkKvittering))
            {
                person.BatchStatus = BatchStatus.SENT;
            }

            if (transportkvittering.GetType() == typeof (TransportFeiletKvittering))
            {
                var feiletkvittering = (TransportFeiletKvittering) transportkvittering;
                person.BatchStatus = BatchStatus.ERROR;
            }
            person.MessageId = transportkvittering.MeldingsId;
            return person;
        }

        private static void InitializeLog(Klientkonfigurasjon klientkonfigurasjon)
        {
            // Legger til logging til outputvinduet
            klientkonfigurasjon.Logger =
                (severity, konversasjonsId, metode, melding) =>
                {
                    Debug.WriteLine("{0} - {1} [{2}]", DateTime.Now, melding, konversasjonsId.GetValueOrDefault());
                };
        }

        public async void HentKvitteringer(List<Person> persons)
        {
            var kvitteringsForespørsel = new Kvitteringsforespørsel(Prioritet.Prioritert, MpcId);
            Console.WriteLine(@" > Henter kvittering på kø '{0}'...", kvitteringsForespørsel.Mpc);

            var kvittering = await SDPClient.HentKvitteringAsync(kvitteringsForespørsel);

            while (true)
            {
                if (kvittering is TomKøKvittering)
                {
                    break;
                }

                UpdatePersonWithReceipt(persons, kvittering);
            }
        }

        private static void UpdatePersonWithReceipt(IEnumerable<Person> persons, Kvittering kvittering)
        {
            foreach (var person in persons.Where(person => person.MessageId == kvittering.MeldingsId))
            {
                if (kvittering is Feilmelding || kvittering is TransportFeiletKvittering)
                {
                    person.BatchStatus = BatchStatus.ERROR;
                    person.StatusMessage = kvittering.GetType().ToString();
                }
                else
                {
                    person.BatchStatus = BatchStatus.SENT_WITH_RECEIPT;
                    person.StatusMessage = kvittering.GetType().ToString();
                }
            }
        }
    }
}