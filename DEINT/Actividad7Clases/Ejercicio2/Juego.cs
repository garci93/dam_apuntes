using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Juego
    {

        public void Jugar()
        {
            Dado[] dados = InicializarDados<Dado>(3);
            bool res = true;
            for (int i = 0; i < dados.Length; i++)
            {
                dados[i].Tirar();
                dados[i].Imprimir();
                if (i != 0 && dados[i].Valor != dados[i-1].Valor) res = false;
            }
            if (res)
                Console.WriteLine("Ganó");
            else
                Console.WriteLine("Perdió");
        }
        public Juego() { }

        T[] InicializarDados<T>(int cantidad) where T : new()
        {
            T[] dados = new T[cantidad];
            for (int i = 0; i < cantidad; ++i)
            {
                dados[i] = new T();
            }

            return dados;
        }
    }
}


//      b. Juego: con un atributo que será un array de tamaño 3 con objetos de tipo Dado y
//          un método Jugar, que debe tirar los tres dados, mostrar su valor y decirnos si
//          hemos perdido o ganado. Las reglas de juego son: se tiran tres dados si los tres
//          salen con el mismo valor mostrar un mensaje que "gano", sino "perdió".