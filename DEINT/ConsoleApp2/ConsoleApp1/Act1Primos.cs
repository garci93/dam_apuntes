namespace Act1Primos
{
    internal class Act1Primos
    {
        static void Main(string[] args)
        {
            int encontrados = 0,numero = 2, divisores;
            //Ejecutar 5 veces
            do {
                divisores = 0;
                //Ejecutar hasta que encuentre un número primo
                for (int j = 2; j < numero; j++)
                {
                    if (numero % j == 0)
                    {
                        divisores++;
                    }
                }
                if (divisores == 0)
                {
                    Console.WriteLine(numero);
                    encontrados++;
                }
                numero++;
            } while (encontrados < 5);
        }
    }
}