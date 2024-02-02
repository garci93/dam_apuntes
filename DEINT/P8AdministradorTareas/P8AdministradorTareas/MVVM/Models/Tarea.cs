using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8AdministradorTareas.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Tarea
    {
        public string Nombre { get; set; }
        public bool Completada { get; set; }
        public string Categoria { get; set; }
    }
}
