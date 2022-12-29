using System;

namespace PaymentContext.Domain.Entities
{
    public class Subscription
    {
        private readonly IList<Payment> _payments;

        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }
        public DateTime? ExpireDate { get; private set; }
        public bool Active { get; private set; }
        public IReadOnlyCollection<Payment> Payments { get; private set; }

        public Subscription(DateTime? expireDate)
        {
            CreateDate = DateTime.UtcNow;
            LastUpdateDate = DateTime.UtcNow;
            ExpireDate = expireDate;
            Active = true;
            _payments = new List<Payment>();
        }

        public void AddPayment(Payment payment)
        {
            _payments.Add(payment);
        }

        public void Activate()
        {
            Active = true;
            LastUpdateDate = DateTime.UtcNow;
        }

        public void Inactivate()
        {
            Active = false;
            LastUpdateDate = DateTime.UtcNow;
        }
    }
}