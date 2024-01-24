using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDemo.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Carrito
    {
        public int PrecioFinal { get; set; }
        public int Descuento { get; set; }
    }
}
