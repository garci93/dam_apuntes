using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasColas1
{
    public class Program
    {
        static void Main(string[] args)
        {
            String exp;

            Console.WriteLine("Introduzca una fórmula");
            exp = Console.ReadLine();

            while (!esValida(exp)) {
                Console.WriteLine("No es correcta. Introduzca una fórmula válida");
                exp = Console.ReadLine();
            }
            Console.WriteLine("La fórmula introducida es " + exp);
        }

        public static bool esValida(String exp)
        {
            bool resultado = true;
            bool hayNumero = false;
            String operadores = "+-*/";
            String contenedores = "([{}])";
            Stack<char> pila = new Stack<char>();

            for (int i = 0;i < exp.Length; i++)
            {
                //SI el carácter anterior es un operador y el actual es un cierre || el ultimo caracter es un operador || el primer caracter es * o /
                if ((i > 0 && operadores.IndexOf(exp[i - 1]) != -1 && (exp[i] == ')' || exp[i] == ']' || exp[i] == '}'))
                    || (i == exp.Length-1 && operadores.IndexOf(exp[i]) != -1)
                    || (i == 0 && (exp[i] == '*' || exp[i] == '/')))
                {
                    resultado = false;
                    break;
                } else if (exp[i] == '(' || exp[i] == '[' || exp[i] == '{')
                {
                    pila.Push(exp[i]);
                } else if (exp[i] == ')')
                {
                    if (pila.Count() != 0 && pila.Peek() == '(') pila.Pop();
                    else
                    {
                        resultado = false;
                        i--;
                        break;
                    }
                } else if (exp[i] == ']')
                {
                    if (pila.Count() != 0 && pila.Peek() == '[') pila.Pop();
                    else
                    {
                        resultado = false;
                        i--;
                        break;
                    }
                } else if (exp[i] == '}')
                {
                    if (pila.Count() != 0 && pila.Peek() == '{') pila.Pop();
                    else
                    {
                        resultado = false;
                        i--;
                        break;
                    }
                }
                if (Char.IsNumber(exp[i])) hayNumero = true;

            }
            if (pila.Count() != 0 || !hayNumero) resultado = false;
            return resultado;
        }
    }
}
