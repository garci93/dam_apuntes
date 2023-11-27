using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardineria.Clases
{
    internal class Pago
    {
        public int CodigoCliente { get; set; }
        public string FormaPago { get; set; }
        public string IdTransaccion { get; set; }
        public DateTime FechaPago { get; set; }
        public double Total { get; set; }
    }
}
