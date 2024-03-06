using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecupMarzo.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Mascota
    {
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public string Foto { get; set; }
        public bool Adoptada { get; set; }

        public Mascota(string nombre, string raza, string foto,bool adoptada)
        {
            Nombre = nombre;
            Raza = raza;
            Foto = foto;
            Adoptada = false;
        }
    }
}
