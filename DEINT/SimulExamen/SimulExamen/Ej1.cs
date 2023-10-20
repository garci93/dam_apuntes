using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    internal static class Ej1
    {
        public static void MostrarIntervalo (this int actual, int limite) { 
            if (actual < limite)
            {
                for (int i = actual; i <= limite; i++)
                {
                    Console.WriteLine(i);
                }
            } else if (actual > limite)
            {
                for (int i = actual; i >= limite; i--)
                {
                    Console.WriteLine(i);
                }
            } else Console.WriteLine(actual);
        }
    }
}
