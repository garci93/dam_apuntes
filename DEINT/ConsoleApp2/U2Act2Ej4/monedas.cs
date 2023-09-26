namespace U2Act2Ej4
{
    internal class monedas
    {
        static void Main(string[] args)
        {
            double precio = 0.45;
            Console.WriteLine("Introduce una cantidad en euros (Precio: "+precio+" euros)");
            double introducido = Convert.ToDouble(Console.ReadLine());
            int cent5, cent10, cent20, cent50, eur1, eur2;
            cent5 = cent10 = cent20 = cent50 = eur1 = eur2 = 0;

            if (introducido >= precio)
            {
                introducido -= precio;
                do
                {
                    if (introducido >= 2)
                    {
                        eur2++;
                        introducido -= 2;
                    }
                    if (introducido >= 1)
                    {
                        eur1++;
                        introducido -= 1;
                    }
                    if (introducido >= 0.5)
                    {
                        cent50++;
                        introducido -= 0.5;
                    }
                    if (introducido >= 0.2)
                    {
                        cent20++;
                        introducido -= 0.2;
                    }
                    if (introducido >= 0.1)
                    {
                        cent10++;
                        introducido -= 0.1;
                    }
                    if (introducido >= 0.05)
                    {
                        cent5++;
                        introducido -= 0.05;
                    }
                } while (introducido >= 0.05);
                Console.WriteLine("El cambio son: \n" + eur2 + " monedas de 2 euros\n" + eur1 + " monedas de 1 euros\n"
                    + cent50 + " monedas de 50 céntimos\n" + cent20 + " monedas de 20 céntimos\n"
                    + cent10 + " monedas de 10 céntimos\n" + cent5 + " monedas de 5 céntimos\n");
            } else
            {
                Console.WriteLine("El importe introducido no es suficiente");
            }
        }
    }
}