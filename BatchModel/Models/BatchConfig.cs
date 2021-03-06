﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchModel.Models
{
    public class BatchConfig
    {
        public string ReturNavn { get; set; }
        public string ReturPostnummer { get; set; }
        public string ReturPoststed { get; set; }
        public string OrgNummerAvsender { get; set; }
        public string ThumbprintAvsenderCertificate { get; set; }
        public BatchMiljø Miljø { get; set; }

        public enum BatchMiljø
        {
            TEST,PROD
        }
        
    }
}
