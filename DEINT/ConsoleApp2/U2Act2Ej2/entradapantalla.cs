using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2Act2Ej2
{
    internal class entradapantalla
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, introduce un número entero");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Has introducido el siguiente número: " + numero);
        }
    }
}