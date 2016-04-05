using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ApiClientShared;
using ApiClientShared.Enums;
using BatchModel.Models;
using Difi.Oppslagstjeneste.Klient;
using Difi.Oppslagstjeneste.Klient.Domene.Entiteter.Enums;

namespace OppslagstjenesteProxy
{
    public static class OppslagstjenesteClient
    {
        public static async Task
            WashPersonList(List<Person> persons)
        {
            var stringList =
                (from item in persons
                    where item.BatchStatus == BatchStatus.NOT_COMPLETE
                    select item
                    into r
                    select r.SocialSecurityNumber).ToArray();

            if (stringList.Length < 1)
                return;

            var oppslagstjenesteKonfigurasjon = new OppslagstjenesteKonfigurasjon(Miljø.FunksjoneltTestmiljø);

            var cert = CertificateUtility.SenderCertificate("8702F5E55217EC88CF2CCBADAC290BB4312594AC",
                Language.Norwegian);

            var oppslagstjenesteKlient = new OppslagstjenesteKlient(cert, oppslagstjenesteKonfigurasjon);

            var result =
                await
                    oppslagstjenesteKlient.HentPersonerAsynkront(stringList, Informasjonsbehov.Person,
                        Informasjonsbehov.Kontaktinfo, Informasjonsbehov.Sertifikat, Informasjonsbehov.SikkerDigitalPost,
                        Informasjonsbehov.VarslingsStatus);

            foreach (var dtoPerson in result)
            {
                foreach (var p in persons.Where(p => p.SocialSecurityNumber == dtoPerson.Personidentifikator))
                {
                    if (dtoPerson.Status == Status.AKTIV)
                    {
                        p.BatchStatus = BatchStatus.WASHED;
                        p.PersonStatus = PersonStatus.ACTIVE;
                    }

                    else
                    {
                        p.BatchStatus = BatchStatus.WASHED;
                        p.PersonStatus = PersonStatus.NOT_REGISTERED;
                        continue;
                    }

                    p.ReservedForDigitallyDelivery = dtoPerson.Reservasjon;
                    if (dtoPerson.Kontaktinformasjon != null)
                    {
                        p.Email = dtoPerson.Kontaktinformasjon.Epostadresse.Epost;
                        p.MobileNumber = dtoPerson.Kontaktinformasjon.Mobiltelefonnummer.Nummer;
                    }
                    if (dtoPerson.SikkerDigitalPostAdresse != null)
                    {
                        p.SikkerDigitalPostAdresse = dtoPerson.SikkerDigitalPostAdresse.Postkasseadresse;
                        p.RecieverProcessorAccountNumber = dtoPerson.SikkerDigitalPostAdresse.PostkasseleverandørAdresse;
                    }

                    if (dtoPerson.X509Sertifikat != null)
                    {
                        var signature = dtoPerson.X509Sertifikat.Export(X509ContentType.Cert);
                        p.X509CertificateRawdata = Convert.ToBase64String(signature);
                        p.Certificate = new X509Certificate2(signature);
                    }
                }
            }
        }

        public static string ExportToString(X509Certificate cert)
        {
            return cert.GetRawCertDataString();
        }
    }
}