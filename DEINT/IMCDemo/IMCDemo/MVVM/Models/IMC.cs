using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCDemo.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class IMC
    {
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double Resultado { get; set; }
    }
}
