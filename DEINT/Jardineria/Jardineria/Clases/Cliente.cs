using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardineria.Clases
{
    internal class Cliente
    {
        string CodigoCliente {  get; set; }
        string NombreCliente { get; set; }
        string? NombreContacto { get; set; }
        string? ApellidoContacto { get; set; }
        string Telefono {  get; set; }
        string Fax {  get; set; }
        string LineaDireccion1 {  get; set; }
        string? LineaDireccion2 { get; set; }
        string Ciudad {  get; set; }
        string? Region { get; set; }
        string? Pais { get; set; }
        string? CodigoPostal { get   ; set; }
        string? CodigoEmpleadoRepVentas { get; set; }
        string? LimiteCredito { get; set; }


    }
}
