using BDDemo2.Abstration;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDemo2.MVVM.Model
{
    public class Passport: TableData
    {
        public DateTime ExpirationDate { get; set; }
        [ForeignKey(typeof(Customer))]
        public int CustomerId { get; set; }

    }
}
