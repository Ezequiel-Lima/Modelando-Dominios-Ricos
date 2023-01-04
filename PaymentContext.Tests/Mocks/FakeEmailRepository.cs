using PaymentContext.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Tests.Mocks
{
    public class FakeEmailRepository : IEmailService
    {
        public void SendEmail(string to, string email, string subject, string body)
        {
            
        }
    }
}
