using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardineria.Clases
{
    internal class Empleado
    {
        int Codigo { get; set; }
        string Nombre { get; set; }
        string Apellido1 { get; set; }
        string? Apellido2 { get; set; }
        string Extension { get; set; }
        string Email { get; set; }
        int CodigoOficina { get; set; }
        int? CodigoJefe { get; set; }
        string? Puesto { get; set; }
        }
}