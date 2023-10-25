using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    internal class Tarea
    {
        
        public Tarea(string nombre, DateTime fechaCreacion) {
            Nombre = nombre;
            FechaCreacion = fechaCreacion;
        }

        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }

        public override string ToString()
        {
            return "Nombre: " + Nombre + "\nFecha de creación: " + FechaCreacion.ToString("dd/MM/yyyy");
        }

    }
}
