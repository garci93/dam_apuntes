using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardineria.Clases
{
    internal class DetallePedido
    {
        public int CodigoPedido { get; set; }
        public string CodigoProducto { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnidad { get; set; }
        public int NumeroLinea { get; set; }
    }
}
