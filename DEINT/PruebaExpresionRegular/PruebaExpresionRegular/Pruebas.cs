using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PruebaExpresionRegular
{
    internal class Pruebas
    {
        public bool comprobar1 (string regexp)
        {
            return Regex.IsMatch("31/12/2001", regexp);;
        }

        public bool comprobar1a(string regexp)
        {
            return !Regex.IsMatch("31122001", regexp); ;
        }

        public bool comprobar1b(string regexp)
        {
            return !Regex.IsMatch("31/12/2001/", regexp); ;
        }

        public bool comprobar2(string regexp)
        {
            return Regex.IsMatch("ejemplo@mail.es", regexp);
        }

        public bool comprobar2a(string regexp)
        {
            return !Regex.IsMatch("ejemplomail.es", regexp);
        }

        public bool comprobar3(string regexp)
        {
            return Regex.IsMatch("285-636-8535", regexp);
        }

        public bool comprobar3a(string regexp)
        {
            return !Regex.IsMatch("285636-8535", regexp);
        }

        public bool comprobar3b(string regexp)
        {
            return !Regex.IsMatch("28567-36-8535", regexp);
        }

        public bool comprobar4(string regexp)
        {
            return Regex.IsMatch("109.46.5.0", regexp);
        }

        public bool comprobar4a(string regexp)
        {
            return Regex.IsMatch("255.255.255.255", regexp);
        }

        public bool comprobar4b(string regexp)
        {
            return !Regex.IsMatch("256.255.255.255", regexp);
        }

        public bool comprobar4c(string regexp)
        {
            return !Regex.IsMatch("256.255.255", regexp);
        }

        public bool comprobar5(string regexp)
        {
            return Regex.IsMatch("00-A3-73-BC-D4-1F", regexp);
        }

        public bool comprobar5a(string regexp)
        {
            return !Regex.IsMatch("00-G3-73-BC-D4-1F", regexp);
        }

        public bool comprobar5b(string regexp)
        {
            return !Regex.IsMatch("00-73-BC-D4-1F", regexp);
        }

        public bool comprobar5c(string regexp)
        {
            return !Regex.IsMatch("34-00-73-BC-D4-1F-", regexp);
        }

        public MatchCollection comprobar6(string regexp)
        {
            return Regex.Matches("avanzar bardo regalo avant-apres sesión ahora", regexp);
        }
    }
}
