//boleto subscription command
using System;
using Flunt.Notifications;
using Flunt.Validations;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Commands;

namespace PaymentContext.Domain.Commands
{
    public class CreateBoletoSubscriptionCommand : Notifiable,ICommand
    {

        public string FisrtName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string BarCode { get; set; }
        public string BoletoNumber { get; set; }        
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

        public void Validate()
        {
            AddNotifications(new Contract()
            .Requires()
            .HasMinLen(FisrtName, 3, "Name.First", "Nome deve conter no mínimo 3 caracteres!")
            .HasMaxLen(FisrtName, 40, "Name.First", "Nome deve conter no máximo 3 caracteres!")
            .HasMinLen(LastName, 3, "Name.Last", "Sobrenome deve conter pelo menos 3 caracteres!")
            .HasMaxLen(LastName, 40, "Name.Last", "Sobrenome deve conter no máximo 40 caracteres"));
        }
    }
}