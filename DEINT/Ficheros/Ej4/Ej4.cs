namespace Ficheros
{
    internal class Ej4
    {
        static void Main(string[] args)
        {
            string ruta = Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory), @"notas.txt");
            Console.WriteLine("Nombre del archivo de destino");
            string nombreNuevo = Console.ReadLine();
            try
            {
                StreamWriter streamW = new StreamWriter(ruta);
                File.Copy(ruta, Path.Combine(Path.GetDirectoryName(Environment.CurrentDirectory), nombreNuevo));
            }
            catch (Exception ex) { };
        }
    }
}
