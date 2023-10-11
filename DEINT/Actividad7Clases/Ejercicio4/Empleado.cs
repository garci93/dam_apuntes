using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Empleado : Persona
    {

        public Empleado(string _nombre, int _edad,  double _sueldo) : base(_nombre, _edad) {
            Sueldo = _sueldo;

        }

        public double Sueldo { get; set; }

        public void MostrarSueldo ()
        {
            Console.WriteLine("Sueldo: " + Sueldo);
        }

        public string ToString ()
        {
            return base.ToString ()+", Sueldo: "+Sueldo;
        }
    }
}
