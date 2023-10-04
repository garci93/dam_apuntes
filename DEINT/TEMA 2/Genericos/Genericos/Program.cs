using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    internal class Genericos
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            string[] cadena = { "a", "b", "c" };
            DateTime[] fechas = { DateTime.Today, DateTime.Today.AddDays(2) };

            Console.WriteLine($"Longitud de array de entero {CalcularLongitudArray(numeros)}");
            Console.WriteLine($"Longitud de array de cadena {CalcularLongitudArray(cadena)}");
            Console.WriteLine($"Longitud de array de fechas {CalcularLongitudArray(fechas)}");
            if (ArrayEstaVacio(cadena))
                Console.WriteLine("El array de cadena está vacío");
            else
                Console.WriteLine("El array de cadena no está vacío");
        }
        static int CalcularLongitudArray <T> (T[] array)
        {
            return array.Length;
        }

        static bool ArrayEstaVacio <T>(T[] array)
        {
            return array.Length == 0;
        }
    }

}
