using System;
using System.Security.Cryptography.X509Certificates;

namespace BatchModel.Models
{
    public class Person
    {
        public Person()
        {
            BatchStatus = BatchStatus.NOT_COMPLETE;
        }

        public Guid? KonversasjonsId { get; set; }

        public string CustomerId { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string FullName { get; set; }
        public string Subject { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string PostalNumber { get; set; }
        public string PostalPlace { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string FilePathAndFileName { get; set; }
        public string Attachment1 { get; set; }
        public string Attachment2 { get; set; }
        public string OrganizationNumber { get; set; }
        public string Country { get; set; }
        public string Kid { get; set; }
        public string AccountNumber { get; set; }
        public decimal? AmountDecimal { get; set; }
        public DateTime? DueDate { get; set; }
        public bool ReservedForDigitallyDelivery { get; set; }
        public string SikkerDigitalPostAdresse { get; set; }
        public string X509CertificateRawdata { get; set; }
        public BatchStatus BatchStatus { get; set; }
        public PersonStatus PersonStatus { get; set; }
        public X509Certificate2 Certificate { get; set; }
        public string RecieverProcessorAccountNumber { get; set; }
        public string StatusMessage { get; set; }


        public string ToCsv()
        {
            return CustomerId + ";" + SocialSecurityNumber + ";" + FullName + ";" + AddressLine1 + ";" + AddressLine2 +
                   ";" +
                   PostalNumber + ";" + PostalPlace + ";" + MobileNumber + ";" + Email + ";" + Subject + ";" +
                   FilePathAndFileName +
                   ";" +
                   Attachment1 + ";" + Attachment2 + ";" + OrganizationNumber + ";" + Country + ";" + Kid + ";" +
                   AccountNumber + ";" + AmountDecimal + ";" + DueDate + ";" + ReservedForDigitallyDelivery + ";" +
                   SikkerDigitalPostAdresse + ";" + X509CertificateRawdata + ";" + RecieverProcessorAccountNumber + ";" +
                   PersonStatus + ";" +
                   BatchStatus + ";" + StatusMessage + ";" + KonversasjonsId;
        }
    }
}