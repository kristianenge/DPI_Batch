using System;

namespace DPI_Batch.Models
{
    public class Person
    {
        public Person()
        {
            Status = Status.NOT_COMPLETE;
        }
        public string CustomerId { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string FullName { get; set; }
        public string Subject { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int PostalNumber { get; set; }
        public string PostalPlace { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string FileName { get; set; }
        public string Attachment1 { get; set; }
        public string Attachment2 { get; set; }
        public string OrganizationNumber { get; set; }
        public string Country { get; set; }
        public string Kid { get; set; }
        public string AccountNumber { get; set; }
        public decimal AmountDecimal { get; set; }
        public DateTime DueDate { get; set; }
        public bool ReservedForDigitallyDelivery { get; set; }

        public Status Status { get; set; }
        
        
    }
}
