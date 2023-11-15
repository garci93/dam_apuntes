using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ej3
{
    internal class Ej3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca la extensión (sin el punto)");
            string extensionArchivo = Console.ReadLine();
            DirectoryInfo directorio = new DirectoryInfo(Path.GetDirectoryName(Environment.CurrentDirectory));
            try
            {
                FileInfo[] archivos = directorio.GetFiles();


                // Comprueba si hay archivos en el directorio
                if (archivos != null && archivos.Length > 0)
                {
                    Console.WriteLine("¿Desea borrar los siguientes archivos? (s/N)");
                    foreach (FileInfo archivo in archivos)
                    {
                        if (archivo.Extension == "." + extensionArchivo)
                        {
                            Console.WriteLine("\t" + archivo.Name);
                        }
                    }
                    string resp = Console.ReadLine().ToLower();
                    if (resp == "s")
                    {
                        Console.WriteLine("Archivos restantes:");
                        foreach (FileInfo archivo in archivos)
                        {
                            if (archivo.Extension == "." + extensionArchivo)
                            {
                                File.Delete(archivo.FullName);
                            } else
                            {
                                Console.WriteLine("\t" + archivo.Name);
                            }
                        }
                    }
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("El directorio está vacío");
            }

        }
    }
}