using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficheros
{
    internal class Ej6
    {
        static void Main(string[] args)
        {
            string ruta = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory), @"enteros.txt");
            try
            {
                StreamReader streamR = new StreamReader(ruta);
                int suma = 0, cantidad = 0;

                while (!streamR.EndOfStream)
                {
                    string[] numerosSeparados = streamR.ReadLine().Split(@",|\s\s?");       //probar con un array de char separadores
                    foreach (string numero in numerosSeparados)
                    {
                        suma += int.Parse(numero);
                        cantidad++;
                    }
                }
                Console.WriteLine(suma);
                Console.WriteLine(cantidad);
                streamR.Close();
                streamR.Dispose();
            }
            catch (Exception ex) { };
        }
    }
}
