using System;
using Flunt.Validations;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    //class abstract onde obriga instaciar as demais class e nunca a abstrata
    public abstract class Payment : Entity
    {
        protected Payment(DateTime paidDate, DateTime exprideDate, decimal total, decimal totalPaid, string payer, Document document, Address address, Email email)
        {
            Number = Guid.NewGuid().ToString().Replace("-","").Substring(0,10).ToUpper();
            PaidDate = paidDate;
            ExprideDate = exprideDate;
            TotalPaid = totalPaid;
            Total = total;
            Payer = payer;
            Document = document;
            Address = address;
            Email = email;

            AddNotifications(new Contract()
            .Requires()
            .IsLowerOrEqualsThan(0, Total, "Payment.Total", "O total não pode ser zero")
            .IsGreaterOrEqualsThan(Total, TotalPaid, "Payment.TotalPaid", "O valor pago é menor que o valor total"));
        }

        public string Number {get; private set;}
        public DateTime PaidDate {get; private set;}
        public DateTime ExprideDate {get; private set;}
        public decimal Total {get; private set;}
        public decimal TotalPaid {get; private set;}
        public string Payer { get; private set; }
        public Document Document { get; private set; }
        public Address Address { get; private set; }
        public Email Email { get; private set; }
    }
}