using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2Actividad8POO
{
    internal class Empleado
    {
        public Empleado(string nombre) {
            Nombre = nombre;
        }
        public string Nombre {  get; set; }

        public string toString ()
        {
            return "Empleado "+Nombre;
        }
    }
}
