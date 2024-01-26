using ExamenMAUIJoseJoaquin.MVVM.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ExamenMAUIJoseJoaquin.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class PedidoViewModel
    {
        public Pedido Pedido { get; set; } = new Pedido();

        public PedidoViewModel()
        {
            Pedido.Valoracion = 4;
            Pedido.Telefono = 123456789;
            Pedido.Correo = "adomicilio@adomicilio.com";
            Pedido.Estado = "Queda poco";
        }
        public ICommand CalificarPedido => new Command(() => Application.Current.MainPage.DisplayAlert("A domicilio", "Gracias por su valoración de un "+Pedido.Valoracion, "OK"));
        public ICommand Llamar => new Command(() => Application.Current.MainPage.DisplayAlert("A domicilio", "Llama al "+Pedido.Telefono, "OK"));
        public ICommand Ayuda => new Command(() => Application.Current.MainPage.DisplayAlert("A domicilio", "Mandar correo a "+Pedido.Correo, "OK"));
    }


}
