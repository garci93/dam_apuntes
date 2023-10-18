using Actividad09;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test1
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void comprobarNumeroEntero()
        {
            bool result = Actividad9.numeroEntero("99");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void comprobarNumeroEnterov2()
        {
            bool result = Actividad9.numeroEntero("aaa");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void comprobarNumeroEnterov3()
        {
            bool result = Actividad9.numeroEntero("aaa88");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void comprobarNumeroEnterov4()
        {
            bool result = Actividad9.numeroEntero(" 88");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void comprobarNumeroPositivo()
        {
            bool result = Actividad9.numeroPositivo("88");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void comprobarNumeroPositivoV2()
        {
            bool result = Actividad9.numeroPositivo("-88");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void comprobarNumeroPositivoV3()
        {
            bool result = Actividad9.numeroPositivo("AAA");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void comprobarNumeroEnterov6()
        {
            bool result = Actividad9.numeroEntero("5.28");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void comprobarCadenaContenedora()
        {
            bool result = Actividad9.cadenaContenedora("perro", "pe");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void comprobarCadenaContenedorav2()
        {
            bool result = Actividad9.cadenaContenedora("PERRO", "pe");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void comprobarCadenaContenedorav3()
        {
            bool result = Actividad9.cadenaContenedora("pepe", "pe");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void comprobarDNI()
        {
            bool result = Actividad9.dni("54138888M");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void comprobarDNIV2()
        {
            bool result = Actividad9.dni("5455138888M");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void comprobarDNIV3()
        {
            bool result = Actividad9.dni("45513888");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void comprobarBinario()
        {
            bool result = Actividad9.isBinario("01110");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void comprobarBinarioV2()
        {
            bool result = Actividad9.isBinario("011510");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void comprobarBinarioV3()
        {
            bool result = Actividad9.isBinario("AAAAA");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void comprobarOctal()
        {
            bool result = Actividad9.isOctal("01234567");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void comprobarOctalV2()
        {
            bool result = Actividad9.isOctal("012345679");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void comprobarOctalV3()
        {
            bool result = Actividad9.isOctal("012345679AA");
            Assert.AreEqual(false, result);
        }

        //la fecha debe de ser DD/MM/AAAA
        [TestMethod]
        public void comprobarFormatoFecha()
        {
            bool result = Actividad9.fechaFormat("05/05/1944");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void comprobarFormatoFechaV2()
        {
            bool result = Actividad9.fechaFormat("1994/05/05");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void comprobarNumeroTelefonoSpain()
        {
            bool result = Actividad9.isSpanish("650419498");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void comprobarNumeroTelefonoSpainv2()
        {
            bool result = Actividad9.isSpanish("+34666409498");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void comprobarNumeroTelefonoSpainv3()
        {
            bool result = Actividad9.isSpanish("+34-666-40-94-98");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void comprobarNumeroTelefonoSpainv4()
        {
            bool result = Actividad9.isSpanish("+0034-666-40-94-98");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void comprobarNumeroTelefonoSpainv5()
        {
            bool result = Actividad9.isSpanish("+0034-950-40-94-98");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void comprobarEmail()
        {
            bool result = Actividad9.isCorrectEmail("alumno@gmail.com");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void comprobarEmailv2()
        {
            bool result = Actividad9.isCorrectEmail("alumno.com");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void comprobarEmailv3()
        {
            bool result = Actividad9.isCorrectEmail("a.little.lengthy.but.fine@dept.example.com");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void comprobarEmailv4()
        {
            bool result = Actividad9.isCorrectEmail("disposable.style.email.with+symbol@example.com");
            Assert.AreEqual(true, result);
        }

    }
}
