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