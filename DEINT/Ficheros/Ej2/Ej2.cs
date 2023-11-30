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
            // combinar(obtener_directorio(dir_actual), nombre_archivo);
            Console.WriteLine("Frase a buscar");
            string frase = Console.ReadLine();

            try
            {
                StreamReader streamR = new StreamReader(ruta);
                int numLinea = 0;
                string lineaActual;
                //mientras no hayamos llegado al final del archivo
                while (!streamR.EndOfStream)
                {
                    numLinea++;
                lineaActual = streamR.ReadLine();
                    if (lineaActual.Contains(frase))
                        Console.WriteLine(numLinea + ": " + lineaActual);
                }
                streamR.Close();
                streamR.Dispose();
            }
            catch (Exception ex) { };
        }
    }
}
