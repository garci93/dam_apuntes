using Microsoft.VisualStudio.TestTools.UnitTesting;
using PruebaTest;

namespace CalculadoraTest
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void sumarDosNumeros()
        {
            int result = Calculadora.suma(2, 4);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void restarDosNumeros()
        {
            int result = Calculadora.resta(2, 4);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void multiplicarDosNumeros()


        {
            int result = Calculadora.multiplicar(2, 4);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void dividirDosNumeros()
        {
            int result = Calculadora.dividir(4, 2);
            Assert.AreEqual(2, result);
        }

    }
}
