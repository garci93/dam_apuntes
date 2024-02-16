using Ejercicio10ControlGastos.MVVM.Model;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10ControlGastos.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]

    public class ControlGastosViewModel
    {
        public List<Cliente> Clientes { get; set; }
        public List<Transaccion> Transacciones {
            get
            {
                return App.TransaccionRepo.GetItems();
            }

            set
            {

            }
        }
        public Cliente Cliente { get; set; }

        public double TotalBalance {
            get
            {
                return obtenerTotalBalance();
            }

            set
            {

            }
        }
        public double Ingreso {
            get
            {
                return obtenerIngresos();
            }

            set
            {

            }
        }
        public double Gasto {
            get
            {
                return obtenerGastos();
            }

            set
            {

            }
        }

        public ControlGastosViewModel()
        {
         
            Clientes = new List<Cliente>()
            {
                new Cliente()
                {
                    Nombre = "Pepieto",
                    Apellido = "Perez",
                    TotalBanco = 1000
                },
                new Cliente()
                {
                    Nombre = "Juanieto",
                    Apellido = "Perez",
                    TotalBanco = 1000
                }
            };

            Cliente = Clientes.First();

        }

        
        private double obtenerTotalBalance()
        {
            return obtenerIngresos() - obtenerGastos();
        }

        private double obtenerIngresos()
        {
            double totalIngresos = 0;

            foreach (var transaccion in Transacciones)
            {
                if (transaccion.EsIngreso)
                {
                    totalIngresos += transaccion.Cantidad;
                }
            }

            return totalIngresos;
        }

        private double obtenerGastos()
        {
            double totalIngresos = 0;

            foreach (var transaccion in Transacciones)
            {
                if (!transaccion.EsIngreso)
                {
                    totalIngresos += transaccion.Cantidad;
                }
            }

            return totalIngresos;
        }
        

        /*
        public void Refresh()
        {
           Transacciones = App.TransaccionRepo.GetItems();
        }
        */

    }
}
