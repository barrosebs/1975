using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class DocumentTests
    {
        //Red, Green, Refactor   
        [TestMethod]
        public void ShouldReturnErrorWhenCNPJIsInvalid()
        {
           var doc = new Document("123", EDocumentType.CNPJ);
           Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenCNPJIsValid()
        {
           var doc = new Document("79084640000187", EDocumentType.CNPJ);
           Assert.IsTrue(doc.Valid);
        }

        [TestMethod]
        public void ShouldReturnErrorWhenCPFIsInValid()
        {
          var doc = new Document("123", EDocumentType.CPF);
           Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("97854851026")]
        [DataRow("37834235036")]
        [DataRow("97049766070")]
        [DataRow("99195614010")]
        public void ShouldReturnSuccessWhenCPFIsValid(string cpf)
        {
           var doc = new Document(cpf, EDocumentType.CPF);
           Assert.IsTrue(doc.Valid);
        }
    }
}
