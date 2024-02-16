using Ejercicio10ControlGastos.Abstraction;
using Humanizer;
using PropertyChanged;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10ControlGastos.MVVM.Model
{
    [AddINotifyPropertyChangedInterface]

    [Table("Transaccion")]
    public class Transaccion : TableData
    {
        [Column("nombre"), Indexed, NotNull]
        public string Nombre { get; set; }


        [Column("cantidad"), NotNull]
        public double Cantidad { get; set; }


        [Column("fecha_transaccion")]
        public DateTime FechaTransaccion { get; set; }


        [Column("es_ingreso")]
        public bool EsIngreso { get; set; }

        public string FechaTransaccionHumanizada => FechaTransaccion.Humanize();

    }
}
