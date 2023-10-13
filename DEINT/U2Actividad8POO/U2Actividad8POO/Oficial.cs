using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2Actividad8POO
{
    internal class Oficial : Operario
    {
        public Oficial(string nombre) : base(nombre)
        {
        }

        public string toString ()
        {
            return base.toString ()+" -> Oficial";
        }

    }
}
