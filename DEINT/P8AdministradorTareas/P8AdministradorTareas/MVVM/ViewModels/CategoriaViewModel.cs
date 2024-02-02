using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8AdministradorTareas.MVVM.ViewModels
{
    public class CategoriaViewModel
    {
        public ObservableCollection <Categoria> Categorias { get; set; } = new ObservableCollection<Categoria>();
        public CategoriaViewModel()
        {
            Categorias = new ObservableCollection<Categoria>()
            {
                new Categoria("Curso .NET MAUI"),
                new Categoria("Tutoriales"),
                new Categoria("Compras")
            };

        } 
    }
}
