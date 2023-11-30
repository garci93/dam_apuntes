using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Cliente
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }
        public int Telefono { get; set; }
        public int NCuentaCorriente { get; set; }

        public Cliente()
        {

        }
        public Cliente(string dni, string nombre, string direccion, int edad, int telefono, int nCuentaCorriente)
        {
            DNI = dni;
            Nombre = nombre;
            Direccion = direccion;
            Edad = edad;
            Telefono = telefono;
            NCuentaCorriente = nCuentaCorriente;
        }
    }
}
