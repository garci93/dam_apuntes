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
        public double PrecioSubtotal { get; set; }
        public double PrecioFinal { get; set; }
        public int Descuento { get; set; }
        public double PrecioDescuento { get; set; }

        public DateTime FechaHoraActual {  get; set; }
    }
}
