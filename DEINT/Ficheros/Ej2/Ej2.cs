using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficheros
{
    internal class Ej2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nombre del archivo");
            string ruta = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory), Console.ReadLine());
            Console.WriteLine("Frase a buscar");
            string frase = Console.ReadLine();

            try
            {
                StreamReader streamR = new StreamReader(ruta);
                int lineaActual = 0;
                while (!streamR.EndOfStream)
                {
                    lineaActual++;
                    if (streamR.ReadLine().Contains(frase))
                        Console.WriteLine(lineaActual + ": " + frase);
                }
                streamR.Close();
                streamR.Dispose();

            }
            catch (Exception ex) { };
        }
    }
}
