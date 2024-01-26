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
        public ICommand LimpiarCommand { get; set; }
        public ICommand BorrarCommand { get; set; }
        public ICommand ResultadoCommand { get; set; }
        public ICommand NumeroCommand { get; set; }
        public Calculadora Calculadora { get; set; }

        public CalculadoraViewModel() {
            Calculadora = new Calculadora()
            {
                Texto = "0",
            };
            LimpiarCommand = new Command(() => Calculadora.Texto = "0");
            BorrarCommand = new Command(() => {
                if (Calculadora.Texto.Length > 1) Calculadora.Texto = Calculadora.Texto.Substring(0, Calculadora.Texto.Length - 1);
                else Calculadora.Texto = "0";
            });
            ResultadoCommand = new Command(() => Calculadora.Texto = Calculator.Calculate(Calculadora.Texto).Result.ToString());
            NumeroCommand = new Command((value) => {
                if (Calculadora.Texto == "0") Calculadora.Texto = value?.ToString();
                else Calculadora.Texto = string.Concat(Calculadora.Texto, value?.ToString());
            });
        }

    }
}
