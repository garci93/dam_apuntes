using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    internal class Perecedero : Producto
    {
        public int DiasACaducar {get; set;}
        public Perecedero(string codigo, string nombre, double precio, int diasACaducar) : base(codigo, nombre, precio)
        {
            DiasACaducar = diasACaducar;
        }

        public Perecedero(string codigo, string nombre, int diasACaducar) : base(codigo, nombre)
        {
            DiasACaducar = diasACaducar;
        }

        public override string ToString()
        {
            return base.ToString() + "\nDías a caducar: " + DiasACaducar;
        }

        public override double Calcular(int cantidad)
        {
            switch (DiasACaducar)
            {
                case 1:
                    return base.Calcular(cantidad) / 4;
                case 2:
                    return base.Calcular(cantidad) / 3;
                case 3:
                    return base.Calcular(cantidad) / 2;
                default:
                    return base.Calcular(cantidad);

            }
        }
    }
}
