using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficheros
{
    internal class Ej3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nombre del archivo a copiar");
            string ruta = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory), Console.ReadLine());
            Console.WriteLine("Nombre del nuevo archivo");
            string nombreNuevo = Console.ReadLine();
            try
            {
                File.Copy(ruta, Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory), nombreNuevo));
            }
            catch (Exception ex) { };
        }
    }
}
