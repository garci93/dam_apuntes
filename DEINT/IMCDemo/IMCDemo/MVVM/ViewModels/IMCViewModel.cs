using IMCDemo.MVVM.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IMCDemo.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class IMCViewModel
    {
        public IMC IMC { get; set; }
        public IMCViewModel()
        {

            IMC = new IMC()
            {
                Peso = 0,
                Altura = 0
            };
        }
    }
}
