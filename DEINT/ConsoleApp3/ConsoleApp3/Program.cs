// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] array;
array = new int[] {1,2,3,4,5};

int[,] matriz = new int[3, 4];

matriz[0,0] = 0;

for (int i = 0; i < matriz.Length; i++)
{
    for (int j = 0; j < matriz.Length; j++)
    {
        Console.Write(matriz[i,j]+" ");
    }
    Console.Write("\n");
}

matriz[^1] = 0;