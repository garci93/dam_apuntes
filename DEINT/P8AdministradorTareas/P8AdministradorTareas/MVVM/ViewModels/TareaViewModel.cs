using P8AdministradorTareas.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8AdministradorTareas.MVVM.ViewModels
{
    public class TareaViewModel
    {
        public ObservableCollection <Tarea> Tareas { get; set; } = new ObservableCollection<Tarea>();
        public TareaViewModel()
        {
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
        }
    }
}
