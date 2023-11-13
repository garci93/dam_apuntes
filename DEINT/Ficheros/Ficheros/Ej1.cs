
namespace Ficheros
{
    internal class Ej1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nombre del archivo 1");
            string ruta = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory), Console.ReadLine());
            Console.WriteLine("Nombre del archivo 2");
            string ruta2 = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory), Console.ReadLine());

            try
            {
                StreamReader streamR = new StreamReader(ruta);

                StreamWriter streamW = new StreamWriter(ruta2);
                while (!streamR.EndOfStream)
                {
                    string s = streamR.ReadLine();
                    streamW.WriteLine(s);
                }
                streamR.Close();
                streamR.Dispose();
                streamW.Close();
                streamW.Dispose();

            }
            catch (Exception ex) { };
        }
    }
}