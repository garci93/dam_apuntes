using CalculadoraDemo.MVVM.Models;
using Dangl.Calculator;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CalculadoraDemo.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class CalculadoraViewModel
    {
        public Calculadora Calculadora { get; set; }

        public CalculadoraViewModel() {
            Calculadora = new Calculadora()
            {
                Texto = "0"
            };
        }
        public ICommand LimpiarCommand => new Command(() => Calculadora.Texto="0");
        public ICommand BorrarCommand => new Command(() => {
            if (Calculadora.Texto.Length > 1) Calculadora.Texto = Calculadora.Texto.Substring(0, Calculadora.Texto.Length - 1);
            else Calculadora.Texto = "0";
        });
        public ICommand ResultadoCommand => new Command(() => Calculadora.Texto = Calculator.Calculate(Calculadora.Texto).ToString());
        public ICommand NumeroCommand => new Command((Text) => Calculadora.Texto = string.Concat(Calculadora.Texto, Text?.ToString()));

    }
}
