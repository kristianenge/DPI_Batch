using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using BatchModel.Models;

namespace BatchClient.ViewModel
{
    public class BatchConfigPresenter : ObservableObject
    {
        private readonly BatchConfig _batchConfig = new BatchConfig();
        private readonly ObservableCollection<string> _history = new ObservableCollection<string>();
        private string _returNavn;
        private string _returPostNummer;
        private string _returPostSted;
        private string _orgNummerAvsender;
        private string _thumbprintAvsenderCertificate;
        private BatchConfig.BatchMiljø _miljø;

        public string ReturNavn
        {
            get { return _returNavn; }
            set
            {
                _returNavn = value;
                RaisePropertyChangedEvent("ReturNavn");
            }
        }

        public string ReturPostnummer
        {
            get { return _returPostNummer; }
            set
            {
                _returPostNummer = value;
                RaisePropertyChangedEvent("ReturPostnummer");
            }
        }

        public string ReturPoststed
        {
            get { return _returPostSted; }
            set
            {
                _returPostSted = value;
                RaisePropertyChangedEvent("ReturPoststed");
            }
        }

        public string OrgNummerAvsender
        {
            get { return _orgNummerAvsender; }
            set
            {
                _orgNummerAvsender = value;
                RaisePropertyChangedEvent("OrgNummerAvsender");
            }
        }
        

        public string ThumbprintAvsenderCertificate
        {
            get { return _thumbprintAvsenderCertificate; }
            set
            {
                _thumbprintAvsenderCertificate = value;
                RaisePropertyChangedEvent("ThumbprintAvsenderCertificate");
            }
        }
        
        public BatchConfig.BatchMiljø Miljø
        {
            get { return _miljø; }
            set
            {
                _miljø = value;
                RaisePropertyChangedEvent("Miljø");
            }
        }

        public IEnumerable<string> History
        {
            get { return _history; }
        }

        public ICommand SaveBatchConfigCommand
        {
            get { return new DelegateCommand(SaveBatchConfig); }
        }

        private void SaveBatchConfig()
        {
            _batchConfig.Miljø = _miljø;
            _batchConfig.OrgNummerAvsender = _orgNummerAvsender;
            _batchConfig.ReturNavn = _returNavn;
            _batchConfig.ReturPostnummer = _returPostNummer;
            _batchConfig.ReturPoststed = _returPostSted;

            AddToHistory("Config saved["+DateTime.Now.ToShortDateString()+"]");
        }

        private void AddToHistory(string item)
        {
            if (!_history.Contains(item))
                _history.Add(item);
        }
    }
}
