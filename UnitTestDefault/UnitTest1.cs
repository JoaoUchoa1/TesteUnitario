using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto.Shared;
using System;

namespace UnitTestDefault
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Inicializar() 
        { 
            
        }
        /*
        [TestMethod]
        public void TestAgeBiggerThan18_Age18yo_IsTrue()
        {
            int age = 18;
            bool result = Helper.VerificaIdadeRisco(age);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestAgeBiggerThan18_Age15yo_IsTrue()
        {
            int age = 15;
            bool result = Helper.VerificaIdadeRisco(age);
            Assert.IsFalse(result);
        }
        */

        [TestMethod]
        [DataRow(60)]
        [DataRow(15)]
        [DataRow(18)]
        public void TestAgeBiggerThan18_Age15yo_IsTrue(int age)
        {
            bool result = Helper.VerificaIdadeRisco(age);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestNameIsRisk()
        {
            string name = "Joao";
            bool result = Helper.VerificaNomeDeRisco(name);
            Assert.IsTrue(result);
        }
    }
}
