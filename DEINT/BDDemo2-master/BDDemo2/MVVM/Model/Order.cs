using BDDemo2.Abstration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDemo2.MVVM.Model
{
    public class Order: TableData
    {
        
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }

    }

}
