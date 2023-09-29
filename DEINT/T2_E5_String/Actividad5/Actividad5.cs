using System;
using System.Linq;

namespace Actividad5
{
    public class Actividad5
    {
        static void Main(string[] args)
        {
        }

        public static string devolverString(string[] vs)
        {
            return String.Concat(vs);

            throw new NotImplementedException();
        }

        public static string devolverStringOrdenado(string[] vs)
        {
            return String.Concat(vs.OrderBy(c => c));

            throw new NotImplementedException();
        }

        public static int contarCaracter(string[] vs, char v)
        {
            int veces = 0;
            for (int i = 0; i < vs.Length; i++)
            {
                for (int j = 0; j < vs[i].Length; j++)
                {
                    if (vs[i][j] == v) veces++;
                }
            }
            return veces;

            throw new NotImplementedException();
        }

        public static int[] sumarArrays(int[] vs1, int[] vs2)
        {
            int[] vsMayor;
            if (vs1.Count() >= vs2.Count())
            {
                vsMayor = vs1;
            } else { 
                vsMayor = vs2;
            }
            for (int i = 0; i < vsMayor.Count(); i++)
            {
                vsMayor[i] += vs2[i];
            }

            return vsMayor;

            throw new NotImplementedException();
        }

        public static int[] multiplicarArrays(int[] vs1, int[] vs2)
        {
            int[] vsMayor;
            if (vs1.Count() >= vs2.Count())
            {
                vsMayor = vs1;
            }
            else
            {
                vsMayor = vs2;
            }
            for (int i = 0; i < vsMayor.Count(); i++)
            {
                vsMayor[i] *= vs2[i];
            }

            return vsMayor;

            throw new NotImplementedException();
        }

        public static bool isPalindromo(string entrada)
        {
            bool resultado = true;
            entrada = entrada.Replace(" ","");
            entrada = entrada.ToLower();
            for (int i = 0; i < entrada.Length/2; i++)
            {
                if (entrada[i] != entrada[entrada.Length - i - 1])
                {
                    resultado = false;
                    break;
                }
            }
            return resultado;
            throw new NotImplementedException();


        }

        public static int contarPalabras(string entrada)
        {
            if (string.IsNullOrEmpty(entrada))
            {
                return 0;
            }
            int espacios = 0;
            for (int i = 0; i < entrada.Length; i++)
            {
                if (entrada[i] == ' ')
                {
                    espacios++;
                }
            }
            return espacios+1;

            throw new NotImplementedException();
        }

        public static int contarCaracteres(string entrada)
        {
            return entrada.Replace(" ","").Count();

            throw new NotImplementedException();
        }
    }
}
