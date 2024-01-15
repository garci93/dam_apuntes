using MVVMDemo.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo.MVVM.ViewModels
{
    public class PersonViewModel
    {
        public Person Person { get; set; }
        public PersonViewModel()
        {
            Person = new Person()
            {
                Name = "Jose",
                Age = 1,
                Married = false,
                BirthDate = new DateTime(2001, 09, 01),
                Weight = 100,
                Lunchtime = new TimeSpan(17, 10, 3)
            };
        }

    }
}
