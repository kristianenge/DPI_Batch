using System;
using System.Collections.Generic;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using DPI_Batch.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DPI_Batch
{
    /// <summary>
    ///     An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnRawdataButtonClick(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog 
            var dlg = new FileOpenPicker();

            // Set filter for file extension and default file extension 
            dlg.FileTypeFilter.Add(".csv");

            var result = await dlg.PickSingleFileAsync();
            var linesInFile = await FileIO.ReadLinesAsync(result);

            var personList = new List<Person>();
            var skipFirstLine = true;
            foreach (var line in linesInFile)
            {
                if (skipFirstLine)
                {
                    skipFirstLine = false;
                    continue;
                }
                var splittedLine = line.Split(';');

                var p = new Person
                {
                    CustomerId = splittedLine[0],
                    SocialSecurityNumber = splittedLine[1],
                    FullName = splittedLine[2],
                    AddressLine1 = splittedLine[3],
                    AddressLine2 = splittedLine[4],
                    PostalNumber = string.IsNullOrEmpty(splittedLine[5]) ? 0 : Convert.ToInt32(splittedLine[5]),
                    PostalPlace = splittedLine[6],
                    MobileNumber = splittedLine[7],
                    Email = splittedLine[8],
                    Subject = splittedLine[9],
                    FileName = splittedLine[10],
                    Attachment1 = splittedLine[11],
                    Attachment2 = splittedLine[12],
                    OrganizationNumber = splittedLine[13],
                    Country = splittedLine[14],
                    Kid = splittedLine[15],
                    AccountNumber = splittedLine[16],
                    AmountDecimal = string.IsNullOrEmpty(splittedLine[17]) ? 0 : Convert.ToDecimal(splittedLine[17]),
                    DueDate = string.IsNullOrEmpty(splittedLine[18])
                        ? DateTime.MinValue
                        : Convert.ToDateTime(splittedLine[18]),
                    Status = string.IsNullOrEmpty(splittedLine[19])
                        ? Status.NOT_COMPLETE
                        : (Status) Enum.Parse(typeof (Status), splittedLine[20])
                };
                personList.Add(p);
            }

            DataGrid.ItemsSource = personList;
        }

        private void BtnOppslagstjeneste_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}