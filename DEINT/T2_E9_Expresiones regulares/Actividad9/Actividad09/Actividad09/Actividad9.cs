using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;

namespace Actividad09
{
    public class Actividad9
    {
        static void Main(string[] args)
        {
        }

        public static bool cadenaContenedora(string cadena, string valor)
        {
            return Regex.IsMatch(cadena,valor);
        }

        public static bool numeroEntero(string v)
        {
            return Regex.IsMatch(v,@"^\d+$");
        }

        public static bool isSpanish(string telefono)
        {
            return Regex.IsMatch(telefono,@"^(\+0{0,2}34)?\-?\d{3}\-?(\d{2}\-?){2}\d{2}$");
        }

        public static bool isCorrectEmail(string email)
        {
            return Regex.IsMatch(email, @"^[\w\.\+]+@(\w+\.)+\w{2,3}$");
        }

        public static bool numeroPositivo(string v)
        {
            return Regex.IsMatch(v, @"^[^-]\d+$");
        }

        public static bool isOctal(string v)
        {
            return Regex.IsMatch(v, @"^[0-7]+$");
        }

        public static bool dni(string v)
        {
            return Regex.IsMatch(v, @"^\d{8}[A-Z]$");
        }

        public static bool fechaFormat(string v)
        {
            return Regex.IsMatch(v, @"\d{2}/\d{2}/\d{4}");
        }

        public static bool isBinario(string v)
        {
            return Regex.IsMatch(v, @"^[01]+$");
        }
    }
}
