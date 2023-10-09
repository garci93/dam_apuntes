using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Dado
    {
        public int Valor { get; set; }
        public Dado() { }

        public void Tirar()
        {
            Random random = new Random();
            Valor = random.Next(1,6);
        }

        public void Imprimir()
        {
            Console.WriteLine(Valor);
        }
    }
}