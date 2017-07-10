using NUnit.Framework;

namespace Application.TestApi.Test.CreditRequestParser
{
    [TestFixture]
    public class EquifaxRequestParserTests : WhenTestingEquifaxRequestParser
    {
        [Test]
        public void ParseApplicant()
        {
            // Act
            var applicant = EquifaxRequestParser.ParseApplicant(XmlRequest);

            // Assert
            Assert.AreEqual("Mr", applicant.Title);
            Assert.AreEqual("John", applicant.ForeName);
            Assert.AreEqual("Smith", applicant.Surname);
            Assert.AreEqual("1983-06-16", applicant.DateOfBirth);
            Assert.AreEqual("1", applicant.CurrentAddress.Number);
            Assert.AreEqual("WR2 6NJ", applicant.CurrentAddress.PostCode);
            Assert.AreEqual("Worcester", applicant.CurrentAddress.PostTown);
            Assert.AreEqual("Moseley Road", applicant.CurrentAddress.Street1);
        }
    }
}