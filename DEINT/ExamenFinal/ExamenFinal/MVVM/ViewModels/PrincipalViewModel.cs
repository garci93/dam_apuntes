using ExamenFinal.MVVM.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ExamenFinal.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class PrincipalViewModel
    {
        public ICommand GuardarCommand { get; set; }

        public Contacto Contacto { get; set; }


        public string Nombre { get; set; }
        public string Foto { get; set; }
        public string Correo { get; set; }
        public string Categoria { get; set; }
        public string Telefono { get; set; }
        public bool Favorito { get; set; }
        public List<Contacto> Contactos
        {
            get
            {
                new List<Contacto>()
                {
                new Contacto() { Nombre = "Manuel", Foto = "Resources\\Images\\dotnet_bot.png", Correo = "a@b.c", Categoria = "Trabajo", Telefono = "666777888", Favorito = false } };
                return new List<Contacto>();

                //return App.ContactoRepo.GetItems().ToList();
            }

            set
            {

            }
        }
        
        public PrincipalViewModel()
        {
            GuardarCommand = new Command(() =>
            {
                App.ContactoRepo.SaveItem(new Contacto()
                {
                    Nombre = Nombre,
                    Foto = Foto,
                    Correo = Correo,
                    Categoria = Categoria,
                    Telefono = Telefono,
                    Favorito = Favorito
                });
            });
        }

    }
}
