using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardineria.Clases
{
    internal class Pedido
    {
        int CodigoPedido { get; set; }
        DateTime FechaPedido { get; set; }
        DateTime FechaEsperada { get; set; }
        DateTime? FechaEntrega { get; set; }
        string Estado { get; set; }
        string? Comentarios { get; set; }
        int CodigoCliente { get; set; }
    }
}
