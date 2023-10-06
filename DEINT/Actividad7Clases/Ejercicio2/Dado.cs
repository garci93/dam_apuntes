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


//a.Dado: con atributo valor y métodos Tirar, que generará un aleatorio entre 1 y 6, y
//          un método Imprimir que mostrará el valor del dado.