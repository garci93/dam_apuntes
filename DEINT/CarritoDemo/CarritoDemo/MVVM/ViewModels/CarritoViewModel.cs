using CarritoDemo.MVVM.Models;
using CarritoDemo.MVVM.Views;
using Microsoft.WindowsAppSDK.Runtime;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CarritoDemo.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class CarritoViewModel
    {
        public Carrito Carrito { get; set; }
        public CarritoViewModel()
        {
            Carrito = new Carrito()
            {
                PrecioFinal = 0,
                Descuento = 10
            };
        }

        public ICommand PagarLuegoCommand => new Command(() => Application.Current.MainPage.DisplayAlert("Nike Store", "Pedido guardado", "OK"));
        public ICommand PagarAhoraCommand => new Command(() => Application.Current.MainPage.DisplayAlert("Nike Store", "Pagado " + Carrito.PrecioFinal + "€", "OK"));

        public string MensajePrecioFinal()
        {
            return "Precio final: " + Carrito.PrecioFinal;
        }

        public string MensajeDescuento()
        {
            return Carrito.Descuento+"%";
        }
    }
}
