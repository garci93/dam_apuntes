using Ejercicio10ControlGastos.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ejercicio10ControlGastos.MVVM.ViewModel
{
    public class TransaccionesViewModel
    { 
        public ICommand Guardar { get; set; }
        public Transaccion Transaccion { get; set; }

        public string Nombre { get; set; }
        public string CantitadTexto {  get; set; }
        public DateTime FechaTransaccion { get; set; }
        public bool EsIngreso { get; set; }

        public TransaccionesViewModel()
        {
            Guardar = new Command(() =>
            {
                double cantidad = Convert.ToDouble(CantitadTexto);

                App.TransaccionRepo.SaveItem(new Transaccion() { Nombre = Nombre, Cantidad = cantidad, FechaTransaccion = FechaTransaccion, EsIngreso = EsIngreso});
            });
        }
        
    }
}
