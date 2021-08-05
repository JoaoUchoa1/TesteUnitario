using NUnit.Framework;
using Projeto.Shared;

namespace NUnitTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(60)]
        [TestCase(15)]
        [TestCase(18)]
        public void VerifyRiskAge(int age)
        {
            bool result = Helper.VerificaIdadeRisco(age);
            Assert.IsTrue(result);
        }
    }
}