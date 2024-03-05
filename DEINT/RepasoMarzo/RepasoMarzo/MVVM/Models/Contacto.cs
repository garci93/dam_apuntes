using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoMarzo.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Contacto
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Foto { get; set; }
        public bool EsFavorito { get; set; }
    }
}
