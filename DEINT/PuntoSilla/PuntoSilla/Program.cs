namespace PuntoSilla
{
    public class Matriz
    {
        int filas, columnas;
        public Matriz(int filas,int columnas)
        {
            this.filas = filas;
        }
        static void Main(string[] args)
        {
            int filas=0, columnas=0;

            bool continuar = false;

            //Pedir dimensiones
            while (!continuar)
            {
                Console.WriteLine("Introduce un número de filas");

                // Si filas es un número entero, continuar

                if (int.TryParse(Console.ReadLine(), out int resultado))
                {
                    continuar = true;
                    filas = resultado;
                }
            }
            continuar = false;

            while (!continuar)
            {
                Console.WriteLine("Introduce un número de columnas");

                // Si columnas es un número entero, continuar

                if (int.TryParse(Console.ReadLine(), out int resultado))
                {
                    continuar = true;
                    columnas = resultado;
                }
            }

            //Introducir valores
            int[,] mat = new int[filas,columnas];
            int valor;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine("Introduce un valor entero");
                    valor = int.Parse(Console.ReadLine());
                    while (!(valor is int) || filas < 0)
                    {
                        Console.WriteLine("Debe ser un número entero");
                        valor = int.Parse(Console.ReadLine());
                    }
                    mat[i,j] = valor;
                }
            }

            //Mostrar matriz
            for (int i = 0; i < filas; i++)
            {
                Console.Write("[");
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(mat[i,j]);
                    if (j != columnas - 1)
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("]\n");
            }
        }
    }
}