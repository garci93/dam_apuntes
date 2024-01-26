using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDemo.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Calculadora
    {
        public string Texto { get; set; }
    }
}
