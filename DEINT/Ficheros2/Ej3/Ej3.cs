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
            Console.WriteLine("Introduzca el nombre del directorio");
            DirectoryInfo directorio = new DirectoryInfo(Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory), Console.ReadLine()));
            try
            {
                if (directorio.Exists)
                {
                    FileInfo[] archivos = directorio.GetFiles();

                    Console.WriteLine("Introduzca el nombre del nuevo subdirectorio");
                    string nuevoDirectorio = Path.Combine(directorio.FullName, Console.ReadLine());
                    Directory.CreateDirectory(nuevoDirectorio);

                    Console.WriteLine("Introduzca la extensión (sin el punto)");
                    string extensionArchivo = Console.ReadLine();

                    // Comprueba si hay archivos en el directorio
                    if (archivos != null && archivos.Length > 0)
                    {
                        foreach (FileInfo archivo in archivos)
                        {
                            if (Regex.IsMatch(archivo.Name, "\\." + extensionArchivo + "$"))
                            {
                                File.Copy(archivo.FullName, Path.Combine(nuevoDirectorio,archivo.Name), true);
                                Console.WriteLine("Copiando "+archivo.Name+"...");
                            }
                        }
                    }
                    else
                    {
                        throw new FileNotFoundException();
                    }
                }
                else
                    throw new DirectoryNotFoundException();
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("El directorio no existe");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("El directorio está vacío");
            }

        }
    }
}