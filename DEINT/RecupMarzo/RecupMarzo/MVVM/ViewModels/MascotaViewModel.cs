using RecupMarzo.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RecupMarzo.MVVM.ViewModels
{
    public class MascotaViewModel
    {
        public List<Mascota> Mascotas = new List<Mascota>
        {
            new Mascota("Pepa", "Persa", "pepa.jpg",true),
            new Mascota("Antonio", "Yorkshire", "antonio.jpg",false),
            new Mascota("Jaime", "Pastor Alemán", "jaime.jpg",false)
        };

        public MascotaViewModel()
        {
        }
    }
}
