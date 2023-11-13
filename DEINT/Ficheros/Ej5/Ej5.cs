using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficheros
{
    internal class Ej5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nombre del archivo 1");
            string ruta1 = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory), Console.ReadLine());
            Console.WriteLine("Nombre del archivo 2");
            string ruta2 = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory), Console.ReadLine());
            string rutaDestino = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory), @"union.txt");
            FileStream fileStream = File.Create(rutaDestino);
            StreamWriter streamW = new StreamWriter(fileStream);

            try
            {
                StreamReader streamR1 = new StreamReader(ruta1);
                StreamReader streamR2 = new StreamReader(ruta2);
                while (!streamR1.EndOfStream)
                {
                    streamW.WriteLine(streamR1.ReadLine());
                    if (!streamR2.EndOfStream) streamW.WriteLine(streamR2.ReadLine());
                }
                while (!streamR2.EndOfStream)
                {
                    streamW.WriteLine(streamR2.ReadLine());
                }
                streamR1.Close();
                streamR1.Dispose();
                streamR2.Close();
                streamR2.Dispose();
                streamW.Close();
                streamW.Dispose();
                fileStream.Close();
                fileStream.Dispose();
            }
            catch (Exception ex) { };
        }
    }
}
