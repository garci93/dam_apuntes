using P8AdministradorTareas.MVVM.Models;
using P8AdministradorTareas.MVVM.Views;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace P8AdministradorTareas.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]

    public class TareaViewModel : INotifyPropertyChanged
    {

        public event EventHandler<string>? NuevoValorEntry;
        //public Command AbrirTareaView2 { get; set; }
        public ObservableCollection <Tarea> Tareas { get; set; } = new ObservableCollection<Tarea>();
        public ObservableCollection<Categoria> Categorias { get; set; } = new ObservableCollection<Categoria>();

        public Command AnadirCategoria { get; set; }
        public string? EntryNuevo { get; private set; }

        public TareaViewModel()
        {
            Tareas.CollectionChanged += (sender, e) => RaisePropertyChanged(nameof(Tareas));
            Tareas = new ObservableCollection<Tarea>()
            {
                new Tarea
                {
                    Nombre = "Actualizar ficheros",
                    Completada = false
                },
                new Tarea
                {
                    Nombre = "Planear siguiente curso",
                    Completada = false
                },
                new Tarea
                {
                    Nombre = "ASP.NET en YouTube",
                    Completada = false
                },
                new Tarea
                {
                    Nombre = "XAML",
                    Completada = false
                },
                new Tarea
                {
                    Nombre = "JavaScript",
                    Completada = true
                },
            };

            Categorias = new ObservableCollection<Categoria>()
            {
                new Categoria("Curso .NET MAUI"),
                new Categoria("Tutoriales"),
                new Categoria("Compras")
            };
        }

        //private async void IrATareaView2()
        //{
        //    TareaView2 v2 = new TareaView2();
        //    await Application.Current.MainPage.Navigation.PushAsync(v2);
        //}

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int ObtenerCantidadTareasPorCategoria(string nombreCategoria)
        {
            // Filtra las tareas cuya categoría coincide con el nombre de la categoría actual
            for (int i = 0; i < Tareas.Count; i++)
            {
                if (Tareas[i].Categoria == nombreCategoria)
                {
                    return Tareas.Count;
                }
            }

            return 0;
        }

        private void AnadirCategoriaMetodo()
        {
            if (!string.IsNullOrEmpty(EntryNuevo))
            {
                Categoria categoria = new Categoria(EntryNuevo);
                Categorias.Add(categoria);
            }
        }

        public void NotificarCambiosProgreso()
        {
            RaisePropertyChanged(nameof(Progreso));
        }

        public double Progreso (Categoria categoria)
        {
            double completadas = Tareas.Where(x => x.Completada && x.Categoria == categoria.Nombre).Count();
            double total = Tareas.Where(x => x.Categoria == categoria.Nombre).Count();
            return completadas / total;
        }
    }
}
