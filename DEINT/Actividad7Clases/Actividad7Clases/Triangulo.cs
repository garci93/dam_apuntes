using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Triangulo
    {

        public double LongIguales { get; set; }
        public double LongDiferente { get; set; }
        public double Altura { get; set; }

        public Triangulo()
        {
            LongDiferente = 3;
            LongIguales = 4;
            Altura = 3.4;
        }

        public double CalcularPerimetro ()
        {
            return LongDiferente + 2 * LongIguales;
        }

        public double CalcularArea ()
        {
            return Altura * LongDiferente / 2;
        }
    }
}