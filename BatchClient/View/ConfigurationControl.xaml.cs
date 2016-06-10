using BatchModel.Models;

namespace BatchClient.View
{
    /// <summary>
    /// Interaction logic for ConfigurationControl.xaml
    /// </summary>
    public partial class ConfigurationControl
    {
        public BatchConfig BatchConfig { get; set; }

        public ConfigurationControl()
        {
            InitializeComponent();
        }
        public ConfigurationControl(BatchConfig config)
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
