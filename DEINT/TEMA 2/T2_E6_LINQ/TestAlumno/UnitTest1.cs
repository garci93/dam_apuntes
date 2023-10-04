using Actividad6;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestAlumno
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestListarAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>
            {
                new Alumno {Nombre = "Pedro",Nota = 5},
                new Alumno {Nombre = "Jorge",Nota = 8},
                new Alumno {Nombre = "Andres",Nota = 3}
            };
            List<string> nombresResult = new List<string>();
            nombresResult = Alumno.getNombres(alumnos);
            List<string> nombres = new List<string>
            {
                "Pedro", "Jorge", "Andres"
            };
            CollectionAssert.AreEquivalent(nombresResult, nombres);
        }

        [TestMethod]
        public void TestListarPorNota()
        {
            List<Alumno> alumnos = new List<Alumno>
            {
                new Alumno {Nombre = "Pedro",Nota = 5},
                new Alumno {Nombre = "Jorge",Nota = 8},
                new Alumno {Nombre = "Andres",Nota = 3}
            };
            Alumno alumnoResult = new Alumno();
            int nota = 5;
            alumnoResult = Alumno.getListadoNota(alumnos, nota);
            string alumnoAComparar = "Pedro";
            Assert.AreEqual(alumnoAComparar, alumnoResult.Nombre);
        }

        [TestMethod]
        public void TestObtenerPrimero()
        {
            List<Alumno> alumnos = new List<Alumno>
            {
                new Alumno {Nombre = "Pedro",Nota = 5},
                new Alumno {Nombre = "Jorge",Nota = 8},
                new Alumno {Nombre = "Andres",Nota = 3}
            };
            Alumno alumnoResult = new Alumno();
            alumnoResult = Alumno.getPrimerAlumno(alumnos);
            string alumnoAComparar = "Pedro";
            Assert.AreEqual(alumnoAComparar, alumnoResult.Nombre);
        }

        [TestMethod]
        public void TestObtenerUltimo()
        {
            List<Alumno> alumnos = new List<Alumno>
            {
                new Alumno {Nombre = "Pedro",Nota = 5},
                new Alumno {Nombre = "Jorge",Nota = 8},
                new Alumno {Nombre = "Andres",Nota = 3}
            };
            Alumno alumnoResult = new Alumno();
            alumnoResult = Alumno.getUltimoAlumno(alumnos);
            string alumnoAComparar = "Andres";
            Assert.AreEqual(alumnoAComparar, alumnoResult.Nombre);
        }

        [TestMethod]
        public void TestSumaNotas()
        {
            List<Alumno> alumnos = new List<Alumno>
            {
                new Alumno {Nombre = "Pedro",Nota = 5},
                new Alumno {Nombre = "Jorge",Nota = 8},
                new Alumno {Nombre = "Andres",Nota = 3}
            };
            int notasTotal;
            notasTotal = Alumno.getSumaNota(alumnos);
            int notas = 16;
            Assert.AreEqual(notas, notasTotal);
        }

        [TestMethod]
        public void TestNotaMaxima()
        {
            List<Alumno> alumnos = new List<Alumno>
            {
                new Alumno {Nombre = "Pedro",Nota = 5},
                new Alumno {Nombre = "Jorge",Nota = 8},
                new Alumno {Nombre = "Andres",Nota = 3}
            };
            int notasTotal;
            notasTotal = Alumno.getNotaMaxima(alumnos);
            int notas = 8;
            Assert.AreEqual(notas, notasTotal);
        }

        [TestMethod]
        public void TestNotaMinim()
        {
            List<Alumno> alumnos = new List<Alumno>
            {
                new Alumno {Nombre = "Pedro",Nota = 5},
                new Alumno {Nombre = "Jorge",Nota = 8},
                new Alumno {Nombre = "Andres",Nota = 3}
            };
            int notasTotal;
            notasTotal = Alumno.getNotaMinima(alumnos);
            int notas = 3;
            Assert.AreEqual(notas, notasTotal);
        }

        [TestMethod]
        public void TestNotaMedia()
        {
            List<Alumno> alumnos = new List<Alumno>
            {
                new Alumno {Nombre = "Pedro",Nota = 5},
                new Alumno {Nombre = "Jorge",Nota = 8},
                new Alumno {Nombre = "Andres",Nota = 3}
            };
            double notasTotal;
            notasTotal = Alumno.getNotaMedia(alumnos);
            double notas = 5.33;
            Assert.AreEqual(notas, notasTotal);
        }

        [TestMethod]
        public void TestNotaPorNombre()
        {
            List<Alumno> alumnos = new List<Alumno>
            {
                new Alumno {Nombre = "Pedro",Nota = 5},
                new Alumno {Nombre = "Jorge",Nota = 8},
                new Alumno {Nombre = "Andres",Nota = 3}
            };
            int notaResult;
            notaResult = Alumno.getNotaPorNombre(alumnos, "Jorge");
            int nota = 8;
            Assert.AreEqual(nota, notaResult);
        }
    }
}
