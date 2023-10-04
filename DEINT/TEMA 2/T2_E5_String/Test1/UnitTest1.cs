using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void comprobarDevolverString()
        {
            //Devolver un solo string con todas las posiciones del array
            string result = Actividad5.Actividad5.devolverString(new string[] { "Luck ", "yo ", "soy ", "tu ", "padre." });
            Assert.AreEqual("Luck yo soy tu padre.", result);
        }

        [TestMethod]
        public void comprobarDevolverStringOrdenado()
        {
            //Devolver un string ordenado
            string result = Actividad5.Actividad5.devolverStringOrdenado(new string[] { "Luck ", "yo ", "soy ", "tu ", "padre." });
            Assert.AreEqual("Luck padre.soy tu yo ", result);
        }

        [TestMethod]
        public void comprobarContadorCaracter()
        {
            //Contar las veces que aparece un caracter en el array
            int result = Actividad5.Actividad5.contarCaracter(new string[] { "Luck ", "yo ", "soy ", "tu ", "padre." }, 'u');
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void comprobarContadorCaracterV1()
        {
            int result = Actividad5.Actividad5.contarCaracter(new string[] { "Luck ", "yo ", "soy ", "tu ", "padre." }, 'z');
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void comprobarSumarDosArray()
        {
            int[] resultSuma = Actividad5.Actividad5.sumarArrays(new int[] { 1, 5, 6, 9 }, new int[] { 5, 4, 6, 5});
            int[] result = new int[] { 6, 9, 12, 14 };
            CollectionAssert.AreEquivalent(result, resultSuma);
        }

        [TestMethod]
        public void comprobarMultiplicarDosArray()
        {
            int[] resultProducto = Actividad5.Actividad5.multiplicarArrays(new int[] { 1, 5, 6, 9 }, new int[] { 5, 4, 6, 5 });
            int[] result = new int[] { 5, 20, 36, 45 };
            CollectionAssert.AreEquivalent(result, resultProducto);
        }

        [TestMethod]
        public void comprobarIsPalindromo()
        {
            string entrada = "hola";
            bool isPalindromo = Actividad5.Actividad5.isPalindromo(entrada);
            Assert.AreEqual(false, isPalindromo);
        }

        [TestMethod]
        public void comprobarIsPalindromoV2()
        {
            string entrada = "Dabale arroz a la zorra el abad";
            bool isPalindromo = Actividad5.Actividad5.isPalindromo(entrada);
            Assert.AreEqual(true, isPalindromo);
        }

        [TestMethod]
        public void comprobarContarPalabras()
        {
            string entrada = "Dabale arroz a la zorra el abad";
            int totalPalabras = Actividad5.Actividad5.contarPalabras(entrada);
            Assert.AreEqual(7, totalPalabras);
        }

        [TestMethod]
        public void comprobarContarPalabrasV2()
        {
            string entrada = "";
            int totalPalabras = Actividad5.Actividad5.contarPalabras(entrada);
            Assert.AreEqual(0, totalPalabras);
        }

        [TestMethod]
        public void comprobarContarCaracteres()
        {
            string entrada = "";
            int totalCaracteres = Actividad5.Actividad5.contarCaracteres(entrada);
            Assert.AreEqual(0, totalCaracteres);
        }

        [TestMethod]
        public void comprobarContarCaracteresV2()
        {
            string entrada = "Dabale arroz a la zorra el abad";
            int totalCaracteres = Actividad5.Actividad5.contarCaracteres(entrada);
            Assert.AreEqual(25, totalCaracteres);
        }
    }
}
