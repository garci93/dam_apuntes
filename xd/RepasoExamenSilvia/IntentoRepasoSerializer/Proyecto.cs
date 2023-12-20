using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntentoRepasoSerializer
{
    public class Proyecto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }

        public List<Tarea> ListaTareas { get; set; }

        public Proyecto() { }
        public Proyecto(string nombre, string descripcion, DateTime fecha, List<Tarea> listaTareas)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Fecha = fecha;
            ListaTareas = listaTareas;
        }
    }
}
