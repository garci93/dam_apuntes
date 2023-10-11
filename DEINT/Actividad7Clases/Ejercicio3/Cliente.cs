using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Cliente
    {

        public string DNI { get; set; }
        public string Nombre { get; set; }
        public double CantidadAhorrada { get; set; }

        public Cliente(string dni,string nombre)
        {
            DNI = dni;
            Nombre = nombre;
            CantidadAhorrada = 0;
        }

        public void Ingresar (double ingreso)
        {
            CantidadAhorrada += ingreso;
        }

        public void Extraer (double extraccion)
        {
            CantidadAhorrada -= extraccion;
        }

        public double ConsultarSaldo ()
        {
            return CantidadAhorrada;
        }

        public string ToString()
        {
            return "DNI: " + DNI + ", Nombre: " + Nombre + ", Saldo: " + CantidadAhorrada;
        }
    }
}