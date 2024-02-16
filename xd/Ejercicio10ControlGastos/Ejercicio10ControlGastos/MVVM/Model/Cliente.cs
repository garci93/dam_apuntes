using Ejercicio10ControlGastos.Abstraction;
using PropertyChanged;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10ControlGastos.MVVM.Model
{
    [AddINotifyPropertyChangedInterface]

    [Table("Cliente")]
    public class Cliente : TableData
    {
        [Column("nombre"), Indexed, NotNull]
        public string Nombre { get; set; }


        [Column("apellido"), NotNull]
        public string Apellido { get; set; }


        [Column("total_banco")]
        public double TotalBanco { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.CascadeInsert | CascadeOperation.CascadeRead | CascadeOperation.CascadeDelete)]
        public List<Transaccion> Transacciones { get; set; }


    }
}
