using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using BatchModel.Models;

namespace BatchClient.View
{
    /// <summary>
    /// Interaction logic for MainControl.xaml
    /// </summary>
    public partial class MainControl 
    {
        public BatchConfig Config;
        public MainControl()
        {
            InitializeComponent();
            Config = new BatchConfig
            {
                ReturNavn = "Posten Norge",
                ReturPostnummer = "0400",
                ReturPoststed = "Oslo",
                OrgNummerAvsender = "984661185",
                ThumbprintAvsenderCertificate = "8702F5E55217EC88CF2CCBADAC290BB4312594AC"
            };
        }

        private void BtnConfig_Click(object sender, RoutedEventArgs e)
        {
            var config = new ConfigurationWindow();

            config.Show();
        
        }
        
    }
}
