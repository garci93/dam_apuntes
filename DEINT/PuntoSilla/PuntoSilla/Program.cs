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
            int valor = 0;
            continuar = false;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    while (!continuar)
                    {
                        Console.WriteLine("Introduce un valor entero");

                        // Si valor es un número entero, continuar

                        if (int.TryParse(Console.ReadLine(), out int resultado))
                        {
                            continuar = true;
                            valor = resultado;
                        }
                    }
                    continuar = false;
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

            //Calcular punto de silla
            bool hayPuntoDeSilla = false;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (esPuntoDeSilla(mat,i,j,filas,columnas)) {
                        Console.WriteLine("La posición [" + j + "," + i + "] es un punto de silla");
                        hayPuntoDeSilla = true;
                    }
                }
            }
            if (!hayPuntoDeSilla)
            {
                        Console.WriteLine("No hay ningún punto de silla");
            }
        }

        //Devolver true si mat[x,y] es el menor valor de su fila y el mayor de su columna
        public static bool esPuntoDeSilla(int[,] mat, int x, int y, int filas, int columnas)
        {
            bool esMenorDeFila=true, esMayorDeColumna=true;
            for(int i = 0; i < filas; i++)
            {
                if (mat[x,y] > mat[i,y])
                {
                    esMenorDeFila = false;
                }
            }
            for (int j = 0; j < columnas; j++)
            {
                if (mat[x,y] < mat[x,j])
                {
                    esMayorDeColumna = false;
                }
            }
            return esMenorDeFila && esMayorDeColumna;
        }
    }
}