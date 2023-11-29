using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardineria.Clases
{
    internal class Producto
    {
        public int CodigoProducto { get; set; }
        public string Nombre { get; set; }
        public string Gama { get; set; }
        public string Dimensiones { get; set; }
        public string Proveedor { get; set; }
        public string DescripcionText { get; set; }
        public int CantidadStock { get; set; }
        public int PrecioVenta { get; set; }
        public int PrecioProveedor { get; set; }
    }
}
