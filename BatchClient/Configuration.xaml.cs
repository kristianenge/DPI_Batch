using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BatchModel.Models;

namespace BatchClient
{
    /// <summary>
    /// Interaction logic for Configuration.xaml
    /// </summary>
    public partial class Configuration : Window
    {
        public BatchConfig BatchConfig { get; set; }
        public Configuration(BatchConfig config)
        {
            BatchConfig = config;
            InitializeComponent();
            PopulateModel();
        }

        private void PopulateModel()
        {
            RB_Prod.IsChecked = BatchConfig.Miljø == BatchConfig.BatchMiljø.PROD;
            RB_Test.IsChecked = BatchConfig.Miljø == BatchConfig.BatchMiljø.TEST;

        }
    }
}
