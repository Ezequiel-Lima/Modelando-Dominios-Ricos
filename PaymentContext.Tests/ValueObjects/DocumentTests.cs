using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.ValueObjects
{
    [TestClass]
    public class DocumentTests
    {
        // Red, Green, Refactor
        [TestMethod]
        public void ShouldReturnErrorWhenCNPJIsInvalid()
        {
            var document = new Document("1234", EDocumentType.CNPJ);

            // Garanta que é verdade que meu documento é invalido
            Assert.IsTrue(document.Invalid);
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenCNPJIsValid()
        {
            var document = new Document("12345678912345", EDocumentType.CNPJ);

            // Garanta que é verdade que meu documento é valido
            Assert.IsTrue(document.Valid);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("342255458068")]
        [DataRow("5413973934")]
        [DataRow("010772846")]
        public void ShouldReturnErrorWhenCPFIsInvalid(string cpf)
        {
            var document = new Document(cpf, EDocumentType.CPF);

            Assert.IsTrue(document.Invalid);
        }

        // Testar muitos CPF de uma vez
        [TestMethod]
        [DataTestMethod]
        [DataRow("34225545806")]
        [DataRow("54139739347")]
        [DataRow("01077284608")]
        public void ShouldReturnSuccessWhenCPFIsValid(string cpf)
        {
            var document = new Document(cpf, EDocumentType.CPF);

            Assert.IsTrue(document.Valid);
        }
    }
}
