using Practica10.Abstraction;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Practica10.MVVM.Models
{
    [Table("Transaccion")]
    public class Transaccion : TableData
    {
        [Column ("fecha")]
        public DateTime Fecha { get; set; }
        [Column ("cantidad"), MaxLength(100)]
        public int Cantidad { get; set; }
        public bool EsIngreso { get; set; }


        //Relacion 1 a 1 
        //[ForeignKey(typeof(Passport))]
        //public int PassportId { get; set; }
        //[OneToOne (CascadeOperations =CascadeOperation.CascadeInsert | CascadeOperation.CascadeRead | CascadeOperation.CascadeDelete)]
        //public Passport Passport { get; set; }


        //Relacion 1 a N
        //[OneToMany(CascadeOperations = CascadeOperation.CascadeInsert | CascadeOperation.CascadeRead | CascadeOperation.CascadeDelete)]
        //public List<Passport> Passport { get; set; }

    }
}