using PropertyChanged;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Ahorcado
    {
        public int Errores { get; set; }
        public ArrayList Palabras { get; set; } = new ArrayList();
    }
}
