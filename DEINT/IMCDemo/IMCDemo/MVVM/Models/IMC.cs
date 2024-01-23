using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace IMCDemo.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class IMC
    {
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double Resultado {
            get
            {
                return Math.Round(10000 * Peso / (Altura * Altura),2);
            }
        }

        public string Nivel
        {
            get
            {
                if (Resultado < 16)
                    return "IMC: Delgadez Severa";
                else if (Resultado < 17)
                    return "IMC: Delgadez Moderada";
                else if (Resultado < 18.5)
                    return "IMC: Delgadez Ligera";
                else if (Resultado < 25)
                    return "IMC: Normal";
                else if (Resultado < 30)
                    return "IMC: Sobrepeso";
                else if (Resultado < 35)
                    return "IMC: Obesidad Clase I";
                else if (Resultado < 40)
                    return "IMC: Obesidad Clase II";
                else
                    return "IMC: Obesidad Clase III";
            }
        }
    }
}
