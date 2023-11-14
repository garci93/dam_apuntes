using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    internal class Ej1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el nombre del directorio");
            DirectoryInfo directorio = new DirectoryInfo(Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory),Console.ReadLine()));
            try
            {
                if (directorio.Exists)
                {
                    FileInfo[] archivos = directorio.GetFiles();

                    // Comprueba si hay archivos en el directorio
                    if (archivos != null && archivos.Length > 0)
                    {
                        DateTime fechaMod = DateTime.MinValue;
                        string nombreArchivo = "";
                        foreach (FileInfo archivo in archivos)
                        {
                            if (archivo.LastAccessTime > fechaMod)
                            {
                                fechaMod = archivo.LastAccessTime;
                                nombreArchivo = archivo.Name;
                            }
                        }
                        Console.Write(nombreArchivo);
                    }
                    else
                    {
                        throw new FileNotFoundException();
                    }
                }
                else
                    throw new DirectoryNotFoundException();
            } catch (DirectoryNotFoundException)
            {
                Console.WriteLine("El directorio no existe");
            } catch (FileNotFoundException)
            {
                Console.WriteLine("El directorio está vacío");
            }
            
        }
    }
}