using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2Actividad8POO
{
    internal class Operario : Empleado
    {
        public Operario(string nombre) : base(nombre)
        {
        }

        public string toString ()
        {
            return base.toString ()+" -> Operario";
        }

    }
}
