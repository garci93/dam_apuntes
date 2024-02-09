using Practica10.Abstraction;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Practica10.MVVM.Models
{
    [Table("Transacciones")]
    public class Transacciones : TableData
    {

        [Column("id"), Indexed, NotNull]
        public string Id { get; set; }
        public DateTime Fecha { get; set; }
        [MaxLength(100)]
        public int Age { get; set; }
        public string Address { get; set; }


        //Relacion 1 a 1 
        //[ForeignKey(typeof(Passport))]
        //public int PassportId { get; set; }
        //[OneToOne (CascadeOperations =CascadeOperation.CascadeInsert | CascadeOperation.CascadeRead | CascadeOperation.CascadeDelete)]
        //public Passport Passport { get; set; }


        //Relacion 1 a N
        [OneToMany(CascadeOperations = CascadeOperation.CascadeInsert | CascadeOperation.CascadeRead | CascadeOperation.CascadeDelete)]
        public List<Passport> Passport { get; set; }


        [Ignore]
        public bool IsYoung =>
                Age > 50 ? true : false;




    }
}