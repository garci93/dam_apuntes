using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenMAUIJoseJoaquin.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Pedido
    {
        public int Valoracion { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }
        public string Estado { get; set; }
        public DateTime FechaActual { get; set; }
    }
}
