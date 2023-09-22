namespace U2Act2Ej3
{
    internal class media
    {
        static void Main(string[] args)
        {
            int cantidad = 4;
            Console.WriteLine("Introduce "+cantidad+" números");
            double total=0,media;
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Número "+(i+1)+" :");
                total += Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("La media es: " + total / cantidad);
        }
    }
}