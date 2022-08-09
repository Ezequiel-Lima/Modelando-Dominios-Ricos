using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AdicionarAssinatura()
        {
            var subscription = new Subscription();
            var student = new Student ("Quiel", "Lima", "12345678912", "quiel@gmail.com");
            student.AddSubscription(subscription);
        }
    }
}
