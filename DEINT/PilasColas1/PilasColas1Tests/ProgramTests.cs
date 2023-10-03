using Microsoft.VisualStudio.TestTools.UnitTesting;
using PilasColas1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasColas1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void validarTest()
        {
            String formula = "(2+[3-12]*{8/3})";
            bool resultado = Program.esValida(formula);
            Assert.IsTrue(resultado);
        }

        [TestMethod()]
        public void validarNoVaciaTest()
        {
            String formula = "";
            bool resultado = Program.esValida(formula);
            Assert.IsFalse(resultado);
        }

        [TestMethod()]
        public void validarSoloNumeroTest()
        {
            String formula = "345";
            bool resultado = Program.esValida(formula);
            Assert.IsTrue(resultado);
        }

        [TestMethod()]
        public void validarConSignosTest()
        {
            String formula = "(-2+[3-12]*{+8/3})";
            bool resultado = Program.esValida(formula);
            Assert.IsTrue(resultado);
        }

        [TestMethod()]
        public void validarSinNumeroTest()
        {
            String formula = "([{}])";
            bool resultado = Program.esValida(formula);
            Assert.IsFalse(resultado);
        }
    }
}