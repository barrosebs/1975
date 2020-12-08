//credcard subscription command
using System;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Commands
{
    public class CreateCreditCardSubscriptionCommand
    {
        public string FisrtName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string CardholderName { get; set; }
        public string CardNumber { get; set; }        
        public string LastTransactionNumber { get; set; }        
        public string PaymentNumber {get; set;}
        public DateTime PaidDate {get; set;}
        public DateTime ExprideDate {get; set;}
        public decimal Total {get; set;}
        public decimal TotalPaid {get; set;}
        public string Payer { get; set; }
        public string PayerDocument { get; set; }
        public EDocumentType PayerDocumentType { get; set; }
        public string PayerEmail { get; set; }
        public Address Address { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }

    }
}