﻿using System;
using System.Linq;

namespace Actividad4
{
    public class Arrays
    {
        static void Main(string[] args)
        {
        }

        public static int minValorArray(int[] array)
        {
            if (array.Length == 0) {
                return 0;
            }
            int min = array[0];
            for (int i = 1;i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
            throw new NotImplementedException();
        }
        public static int[] invertirArray(int[] array)
        {
            int aux;
                for (int i = 0; i < array.Length/2; i++)
                {
                    aux = array[array.Length - i - 1];
                    array[array.Length - i - 1] = array[i];
                    array[i] = aux;
                }
            return array;
            throw new NotImplementedException();
        }

        public static int comprobarValorEnArray(int[] array, int valor)
        {
            int posicion = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (valor == array[i])
                {
                    posicion = i;
                    break;
                }
            }
            return posicion;
            throw new NotImplementedException();
        }

        public static int calcularModa(int[] entrada)
        {
            int cont = 0;
            int aux = 0;
            int masRepe = 0;

            for (int i = 0; i < entrada.Length; i++)
            {
                cont = 0;

                for (int j = 0; j < entrada.Length; j++)
                {
                    if (entrada[i] == entrada[j])
                    {
                        cont++;
                    }
                }
                if (cont >= aux)
                {
                    if (cont == aux)
                    {
                        int hayDos = entrada[i];
                        if (masRepe < hayDos)
                        {
                            masRepe = hayDos;
                        }
                    }
                    else
                    {
                        aux = cont;
                        masRepe = entrada[i];
                    }
                }
            }

            if (aux == 1)
            {
                return entrada[0];
            }
            else
            {
                return masRepe;
            }
            throw new NotImplementedException();
        }
    }
}
