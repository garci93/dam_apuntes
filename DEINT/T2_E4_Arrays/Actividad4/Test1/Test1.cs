using Actividad4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test1
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void comprobarMinValorArray()
        {
            int result = Arrays.minValorArray(new int[] { 1, 2, 3, 4, 5, 68, 8, 56, 99 });
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void comprobarMinValorArrayVacio()
        {
            int result = Arrays.minValorArray(new int[] { });
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void invertirArray()
        {
            int[] entrada = new int[] { 1, 2, 3, 4, 5, 68, 8, 56, 99 };
            int[] result = new int[] { 99, 56, 8, 68, 5, 4, 3, 2, 1 };
            CollectionAssert.AreEquivalent(result, Arrays.invertirArray(entrada));
        }

        [TestMethod]
        public void invertirArrayV2()
        {
            int[] entrada = new int[] { };
            int[] result = new int[] { };
            CollectionAssert.AreEquivalent(result, Arrays.invertirArray(entrada));
        }

        [TestMethod]
        public void comprobarValorEnArray()
        {
            int[] entrada = new int[] { 1, 2, 3, 4, 5, 68, 8, 56, 99 };
            int valor = 5;
            int posicion = 4;
            Assert.AreEqual(posicion, Arrays.comprobarValorEnArray(entrada, valor));
        }

        [TestMethod]
        public void comprobarValorEnArrayV2()
        {
            int[] entrada = new int[] { };
            int valor = 5;
            int posicion = -1;
            Assert.AreEqual(posicion, Arrays.comprobarValorEnArray(entrada, valor));
        }

        [TestMethod]
        public void comprobarValorEnArrayV3()
        {
            int[] entrada = new int[] { 1, 2, 3, 4, 5, 68, 8, 56, 99 };
            int valor = 100;
            int posicion = -1;
            Assert.AreEqual(posicion, Arrays.comprobarValorEnArray(entrada, valor));
        }

        [TestMethod]
        public void comprobarValorEnArrayV4()
        {
            int[] entrada = new int[] { 1, 2, 3, 4, 5, 68, 8, 2, 99 };
            int valor = 2;
            int posicion = 1;
            Assert.AreEqual(posicion, Arrays.comprobarValorEnArray(entrada, valor));
        }

        [TestMethod]
        public void calcularModa()
        {
            int[] entrada = new int[] { 20, 4, 5, 4, 5, 4, 20, 20, 20 };
            Assert.AreEqual(20, Arrays.calcularModa(entrada));
        }

        [TestMethod]
        public void calcularModaV1()
        {
            //Si no se encuentra ninguno se devuelve la primera posicion
            int[] entrada = new int[] { 2, 4, 5};
            Assert.AreEqual(2, Arrays.calcularModa(entrada));
        }

        [TestMethod]
        public void calcularModaV2()
        {
            //Si el array esta vacio se devuelve 0
            int[] entrada = new int[] { };
            Assert.AreEqual(0, Arrays.calcularModa(entrada));
        }

        [TestMethod]
        public void calcularModaV3()
        {
            //Si dos numeros son moda, se devuelve el mayor
            int[] entrada = new int[] { 20, 4, 5, 4, 5, 4, 20, 20, 20, 4 };
            Assert.AreEqual(20, Arrays.calcularModa(entrada));
        }

        [TestMethod]
        public void calcularModaV4()
        {
            //Si dos numeros son moda, se devuelve el mayor
            int[] entrada = new int[] { 20, 4, 5, 4, 5, 4, 20, 20, 20, 4 };
            Assert.AreEqual(20, Arrays.calcularModa(entrada));
        }
    }
}
