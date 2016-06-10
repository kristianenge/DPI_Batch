using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using BatchModel.Models;
using Microsoft.Win32;
using OppslagstjenesteProxy;
using SikkerDigitalPostProxy;

namespace BatchClient.View
{
    /// <summary>
    ///     Interaction logic for GridControl.xaml
    /// </summary>
    public partial class GridControl
    {
        public GridControl()
        {
            InitializeComponent();
        }

        public string FileName { get; set; }

        public Client Client
        {
            get
            {
                if (Client == null)
                    return new Client(new BatchConfig());
                return Client;
            }
            set { Client = value; }
        }

        private void BtnRawdataButtonClick(object sender, RoutedEventArgs e)
        {
            var theDialog = new OpenFileDialog
            {
                Title = "Open Csv File",
                Filter = "CSV files|*.csv"
            };
            var result = theDialog.ShowDialog();
            FileName = theDialog.FileName;

            var personList = new List<Person>();
            if (!(bool) result) return;

            var filelines = File.ReadAllLines(FileName);
            var skipFirstLine = true;
            foreach (var line in filelines)
            {
                if (skipFirstLine)
                {
                    skipFirstLine = false;
                    continue;
                }
                if (string.IsNullOrEmpty(line))
                    continue;

                var splittedLine = line.Split(';');

                var p = new Person
                {
                    CustomerId = splittedLine[0],
                    SocialSecurityNumber = splittedLine[1],
                    FullName = splittedLine[2],
                    AddressLine1 = splittedLine[3],
                    AddressLine2 = splittedLine[4],
                    PostalNumber = splittedLine[5],
                    PostalPlace = splittedLine[6],
                    MobileNumber = splittedLine[7],
                    Email = splittedLine[8],
                    Subject = splittedLine[9],
                    FilePathAndFileName = splittedLine[10],
                    Attachment1 = splittedLine[11],
                    Attachment2 = splittedLine[12],
                    OrganizationNumber = splittedLine[13],
                    Country = splittedLine[14],
                    Kid = splittedLine[15],
                    AccountNumber = splittedLine[16],
                    AmountDecimal =
                        string.IsNullOrEmpty(splittedLine[17]) ? (decimal?) null : Convert.ToDecimal(splittedLine[17]),
                    DueDate = string.IsNullOrEmpty(splittedLine[18])
                        ? (DateTime?) null
                        : Convert.ToDateTime(splittedLine[18]),
                    ReservedForDigitallyDelivery =
                        string.IsNullOrEmpty(splittedLine[19]) ? false : bool.Parse(splittedLine[19]),
                    SikkerDigitalPostAdresse = splittedLine[20],
                    X509CertificateRawdata = splittedLine[21],
                    RecieverProcessorAccountNumber = splittedLine[22],
                    PersonStatus =
                        string.IsNullOrEmpty(splittedLine[23])
                            ? PersonStatus.UNKNOWN
                            : (PersonStatus) Enum.Parse(typeof (PersonStatus), splittedLine[23]),
                    BatchStatus = string.IsNullOrEmpty(splittedLine[24])
                        ? BatchStatus.NOT_COMPLETE
                        : (BatchStatus) Enum.Parse(typeof (BatchStatus), splittedLine[24]),
                    StatusMessage = splittedLine[25],
                    KonversasjonsId =
                        string.IsNullOrEmpty(splittedLine[26]) ? (Guid?) null : Guid.Parse(splittedLine[26])
                };
                if (!string.IsNullOrEmpty(p.X509CertificateRawdata))
                {
                    p.Certificate = new X509Certificate2(Convert.FromBase64String(p.X509CertificateRawdata));
                }
                personList.Add(p);
            }

            DataGrid.ItemsSource = personList;
        }

        private async void BtnOppslagstjeneste_Click(object sender, RoutedEventArgs e)
        {
            var persons = DataGrid.ItemsSource as List<Person>;

            try
            {
                await OppslagstjenesteClient.WashPersonList(persons);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                PersistCsv(persons);
                DataGrid.Items.Refresh();
            }
        }

        private void PersistCsv(IEnumerable<Person> persons)
        {
            File.Delete(FileName);
            var lines = new List<string>
            {
                "CustomerId; SocialSecurityNumber; FullName; AddressLine1; AddressLine2;PostalNumber;PostalPlace ; MobileNumber; Email ;Subject; FileName;Attachment1; Attachment2 ; OrganizationNumber ;Country ; Kid ;AccountNumber ; AmountDecimal ; DueDate ;ReservedForDigitallyDelivery; SikkerDigitalPostAdresse; X509CertificateRawdata;RecieverProcessorAccountNumber; PersonStatus;BatchStatus;StatusMessage;MessageID"
            };
            lines.AddRange(persons.Select(person => person.ToCsv()));
            File.WriteAllLines(FileName, lines);
        }


        private async void BtnSend_OnClick(object sender, RoutedEventArgs e)
        {
            var persons = DataGrid.ItemsSource as List<Person>;
            for (var i = persons.Count - 1; i >= 0; i--)
            {
                if (persons[i].BatchStatus != BatchStatus.WASHED || persons[i].PersonStatus != PersonStatus.ACTIVE)
                    continue;
                try
                {
                    var updatedPerson = await Client.Send(persons[i]);
                    persons[i] = updatedPerson;

                    PersistCsv(persons);
                    DataGrid.Items.Refresh();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private async void BtnCheckReceipt_Click(object sender, RoutedEventArgs e)
        {
            var persons = DataGrid.ItemsSource as List<Person>;
            var shouldContinue = true;
            while (shouldContinue)
            {
                try
                {
                    shouldContinue = await Client.HentKvitteringer(persons);
                }
                catch (Exception exception)
                {
                    shouldContinue = false;
                    MessageBox.Show(exception.Message);
                }
                finally
                {
                    PersistCsv(persons);
                    DataGrid.Items.Refresh();
                }
            }
        }
    }
}