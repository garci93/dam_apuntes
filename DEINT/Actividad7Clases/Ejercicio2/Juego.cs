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
            Dado[] dados = InicializarDados(3);
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

        Dado[] InicializarDados(int cantidad)
        {
            Dado[] dados = new Dado[cantidad];
            for (int i = 0; i < cantidad; ++i)
            {
                dados[i] = new Dado();
            }

            return dados;
        }
    }
}