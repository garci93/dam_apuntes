using CarritoDemo.MVVM.Models;
using CarritoDemo.MVVM.Views;
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
                Descuento = 10,
                PrecioSubtotal = 185.90,
                PrecioDescuento = 0,
                FechaHoraActual = DateTime.Now
            };
            Carrito.PrecioDescuento = CalcularDescuento();
            Carrito.PrecioFinal = CalcularTotal();

            BotonMas = new Command(() =>
            {
                if (Carrito.Descuento < 100) Carrito.Descuento += 10;
                Carrito.PrecioDescuento = CalcularDescuento();
                Carrito.PrecioFinal = CalcularTotal();
            });

            BotonMenos = new Command(() =>
            {
                if (Carrito.Descuento > 0) Carrito.Descuento -= 10;
                Carrito.PrecioDescuento = CalcularDescuento();
                Carrito.PrecioFinal = CalcularTotal();
            });
        }

        public ICommand BotonMas { get; set; }
        public ICommand BotonMenos { get; set; }
        public double CalcularDescuento()
        {
            return Carrito.PrecioSubtotal * Carrito.Descuento / 100;
        }

        public double CalcularTotal()
        {
            return Carrito.PrecioSubtotal - Carrito.PrecioDescuento;
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
