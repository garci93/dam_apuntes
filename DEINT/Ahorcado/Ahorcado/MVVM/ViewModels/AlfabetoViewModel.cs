using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado.MVVM.ViewModels
{
    public class AlfabetoViewModel
    {
        public List<String> Alfabeto { get; set; } = new List<String>();
        public AlfabetoViewModel()
        {
            for (char letra = 'A'; letra <= 'Z'; letra++)
            {
                Alfabeto.Add(letra.ToString());
            }
        }
    }
}
