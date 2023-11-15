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
            Console.WriteLine("Introduzca el nombre del archivo");
            string nombreArchivo = Console.ReadLine();
            Console.WriteLine("Introduzca la extensión (sin el punto)");
            string extensionArchivo = Console.ReadLine();
            DirectoryInfo directorio = new DirectoryInfo(Path.GetDirectoryName(Environment.CurrentDirectory));
            try
            {
                FileInfo[] archivos = directorio.GetFiles();
                // Comprueba si hay archivos en el directorio
                if (archivos != null && archivos.Length > 0)
                {
                    foreach (FileInfo archivo in archivos)
                    {
                        if (archivo.Name == nombreArchivo + archivo.Extension)
                        {
                            File.Copy(archivo.FullName, Path.Combine(directorio.FullName,nombreArchivo+"."+extensionArchivo), true);
                            File.Delete(archivo.FullName);
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

//Realiza un programa que haciendo uso de la clase Path, cambie la extensión a un
//fichero. Para ello tendrás que solicitar al usuario el nombre de un fichero, y la
//nueva extensión, haciendo una copia de dicho fichero con la nueva extensión, y
//posteriormente borrarás el fichero original.