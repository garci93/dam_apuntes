using P8AdministradorTareas.MVVM.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8AdministradorTareas.MVVM
{
    [AddINotifyPropertyChangedInterface]
    public class Categoria
    {
        public string Nombre { get; set; }
        public int Completadas { get; set; }

        public Categoria(string nombre)
        {
            Nombre = nombre;
            Completadas = 0;
        }
    }
}
