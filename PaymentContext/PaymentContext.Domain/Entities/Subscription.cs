using System;
using System.Collections.Generic;
using System.Linq;
using Flunt.Validations;
using PaymentContext.Shared.Entities;

namespace   PaymentContext.Domain.Entities
{
    
    public class Subscription : Entity
    {
        private IList<Payment> _payment;
        public Subscription(DateTime? expireDate)
        {
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
            ExpireDate = expireDate;
            Active = true; //depende do modelo de assinatura, se no momento ou no retorno de confirmação de pagamento
            _payment = new List<Payment>();
        }

        public  DateTime CreateDate {get; private set;}
        public  DateTime LastUpdateDate {get; private set;}
        public  DateTime? ExpireDate {get; private set;}
        public bool Active {get; private set;}
        public IReadOnlyCollection<Payment> Payments { get { return _payment.ToArray(); } }

        public void AddPayment(Payment payment){
            AddNotifications(new Contract()
            .Requires()
            .IsGreaterThan(DateTime.Now, payment.PaidDate, "Subscription.Payment", "A Data do pagamento deve ser futura!"));

            //add se for válido
            if(Valid)
            _payment.Add(payment);

        }

        public void Activate(){
            Active = true;
            LastUpdateDate = DateTime.Now;
        }

        public void Inactivate(){
            Active = false;
            LastUpdateDate = DateTime.Now;
        }
    }
}