using System;
using System.Collections.Generic;
using System.Linq;

namespace Actividad6
{
    public class Alumno
    {
        static void Main(string[] args)
        {
        }

        public string Nombre { get; set; }
        public int Nota { get; set; }

        public static List<string> getNombres(List<Alumno> alumnos)
        {
            return alumnos.Select(a => a.Nombre).ToList();
        }

        public static Alumno getListadoNota(List<Alumno> alumnos, int nota)
        {
            return alumnos.FirstOrDefault(a => a.Nota == nota);
        }

        public static Alumno getPrimerAlumno(List<Alumno> alumnos)
        {
            return alumnos.First();
        }

        public static Alumno getUltimoAlumno(List<Alumno> alumnos)
        {
            return alumnos.Last();
        }

        public static int getSumaNota(List<Alumno> alumnos)
        {
            return alumnos.Select(a => a.Nota).Sum();
        }

        public static int getNotaMaxima(List<Alumno> alumnos)
        {
            return alumnos.Select(a => a.Nota).Max();
        }

        public static int getNotaMinima(List<Alumno> alumnos)
        {
            return alumnos.Select(a => a.Nota).Min();
        }

        public static int getNotaPorNombre(List<Alumno> alumnos, string v)
        {
            return alumnos.FirstOrDefault(a => a.Nombre == v).Nota;
        }

        public static double getNotaMedia(List<Alumno> alumnos)
        {
            return Math.Round(alumnos.Select(a => a.Nota).Average(),2);
        }
    }
}
