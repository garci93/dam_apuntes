using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    internal class NoPerecedero : Producto
    {
        public string Tipo {  get; set; }
        public NoPerecedero(string codigo, string nombre, double precio, string tipo) : base(codigo, nombre, precio)
        {
            Tipo = tipo;
        }

        public NoPerecedero(string codigo, string nombre, string tipo) : base(codigo, nombre)
        {
            Tipo = tipo;
        }

        public override string ToString()
        {
            return base.ToString() + "\nTipo: " + Tipo;
        }

        public new double Calcular(int cantidad) => base.Calcular(cantidad);
    }
}
