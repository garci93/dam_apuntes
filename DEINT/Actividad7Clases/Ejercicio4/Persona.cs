using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Persona
    {
        public Persona(string _nombre, int _edad) {
            Nombre = _nombre;
            Edad = _edad;
        }
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public string toString ()
        {
            return "Nombre: " + Nombre + ", Edad: " + Edad;
        }
    }
}
