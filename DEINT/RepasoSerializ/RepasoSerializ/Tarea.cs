using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoSerializ
{
    public enum TipoEstado
    {
        PENDIENTE, EN_PROGRESO, COMPLETADA
    }
    public class Tarea
    {
        public string Nombre {  get; set; }
        public string Descripcion { get; set; }
        public DateTime fecha { get; set; }
        public TipoEstado Estado { get; set; }
        public Tarea()
        {

        }

        public Tarea(string nombre, string descripcion, DateTime fecha, TipoEstado estado)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            this.fecha = fecha;
            Estado = estado;
        }
    }
}
