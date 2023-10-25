using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    internal class ExceptionPersonalizada:Exception
    {

        public ExceptionPersonalizada(): base("Esta es una expcion personalizada")
        {
               
        }

        public ExceptionPersonalizada(string? mensaje): base(mensaje)
        {

        }
    }
}
