using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ej2
{
    internal class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Producto(string codigo, string nombre, double precio) {
            Regex regex = new Regex(@"^[A-Z]{3}\-\d{3}[A-Z]$");
            try
            {
                if (!regex.IsMatch(codigo))
                    throw new CodigoInvalidoException();
                Codigo = codigo;

            } catch (CodigoInvalidoException e) { }
            Nombre = nombre;
            Precio = precio;
        }

        public Producto(string codigo, string nombre)
        {
            Regex regex = new Regex(@"^[A-Z]{3}\-\d{3}[A-Z]$");
            try
            {
                if (!regex.IsMatch(codigo))
                    throw new CodigoInvalidoException();
                Codigo = codigo;

            }
            catch (CodigoInvalidoException e) { }
            Nombre = nombre;
            Precio = 0;
        }

        public override string ToString()
        {
            return "Código: " + Codigo + "\nNombre: " + Nombre + "\nPrecio: " + Precio;
        }

        public virtual double Calcular(int cantidad)
        {
            return Precio * cantidad;
        }
    }
}
