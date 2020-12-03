using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class CredCardPayment : Payment
    {
        public CredCardPayment(string cardHolderName, string cardNumber, string lastTransactionNumber, 
                             DateTime paidDate, DateTime exprideDate, decimal total, 
                               decimal totalPaid, string payer, Document document, Address address, Email email) 
                            : base(paidDate, exprideDate, total, totalPaid, payer, document, address, email)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
               
        }
            public string CardHolderName { get; private set; }
            public string CardNumber { get; private set; }
            public string LastTransactionNumber { get; private set; }
    }
}