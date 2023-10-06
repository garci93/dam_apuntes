using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_E6_b
{
    public class Ejercicio2
    {
        public static void Main(String[] args)
        {
            /* Este ejercicio consiste en generar (usando operadores LINQ) una lista de enteros, de 1 a
                100, y devolver solo la lista de los números divisibles entre 7. Los números resultado son 7,
                14, 21, 28, 35, 42, 49, 56, 63, 70, 77, 84, 91 y 98. */

            int[] numeros = Enumerable.Range(1, 100).ToArray();

            int[] divisibles = numeros.Where(x => x % 7 == 0).ToArray();

            for (int i = 0; i < divisibles.Length; i++)
            {
                Console.WriteLine(divisibles[i]);
            }
            Console.WriteLine();

            /* Una vez obtenido este resultado, se divide en dos grupos: los números pares y los números
                impares. Cada uno de los grupos debe ser mostrado por su nombre (par o impar) y los
                números correspondientes que tienen. */

            var agrupados = divisibles.GroupBy(p => p % 2 == 0).ToList();
            foreach (var i in agrupados)
            {
                if (i.Key)
                    Console.WriteLine("Pares:");
                else
                    Console.WriteLine("Impares:");
                foreach (var j in i)
                {
                    Console.WriteLine(j);
                }
                Console.WriteLine();
            }


        }
    }
}
