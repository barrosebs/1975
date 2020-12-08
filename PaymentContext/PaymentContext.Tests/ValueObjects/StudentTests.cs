using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.ValueObjects
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void ShouldReturnErrorWhenActiveSubscription()
        {
            var name = new Name("Bruce","Wayne");
            var document = new Document("48705302013", EDocumentType.CPF);
            var email = new Email("batman@batman.com");
            var student = new Student(name, document,email);

            Assert.Fail();
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenHadNoActiveSubscription()
        {
            Assert.Fail();
        }
    }
}