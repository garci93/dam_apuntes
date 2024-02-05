using BDDemo2.Abstration;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDemo2.MVVM.Model
{
    [Table("Customers")]
    public class Customer : TableData
    {

        [Column("name"), Indexed, NotNull]
        public string Name { get; set; }
        [Unique]
        public string Phone { get; set; }
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
