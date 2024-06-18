using ExamenJunio.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenJunio.MVVM.ViewModels
{
    public class SneakerViewModel
    {
        public List<Sneaker> Sneakers = new List<Sneaker>
        {
            new Sneaker("NMD_R1", "candy", 162, "candy.jpg", false),
            new Sneaker("NMD_R1", "pink white", 142, "candy.jpg", false),
            new Sneaker("NMD_R1", "mint pink", 179, "candy.jpg", true),
            new Sneaker("NMD_R1", "white mint", 154, "candy.jpg", false),
        };

        public SneakerViewModel()
        {
            ToggleFavoriteCommand = new Command<ClickedEventArgs>(ToggleFavorite);
        }

        private void ToggleFavorite(ClickedEventArgs args)
        {
            //Pasar el objeto sneaker donde se ha hecho clic al metodo ToggleFavorite
            Sneaker.ToggleFavorite(args(EsteSneaker));
        }

        public List<Sneaker> GetSneakers()
        {
            return Sneakers;
        }

        public void AddSneaker(Sneaker sneaker)
        {
            Sneakers.Add(sneaker);
        }

        public void RemoveSneaker(Sneaker sneaker)
        {
            Sneakers.Remove(sneaker);
        }

        public void UpdateSneaker(Sneaker sneaker)
        {
            var sneakerToUpdate = Sneakers.FirstOrDefault(s => s.Brand == sneaker.Brand && s.Color == sneaker.Color);
            if (sneakerToUpdate != null)
            {
                sneakerToUpdate.Price = sneaker.Price;
                sneakerToUpdate.Image = sneaker.Image;
                sneakerToUpdate.IsFavorite = sneaker.IsFavorite;
            }
        }

        public Command<ClickedEventArgs> ToggleFavoriteCommand;

        Binding Image = new Binding(nameof(Sneaker.Image));

        public Binding ImageBinding
        {
            get => Image;
        }
        public void ToggleFavorite(Sneaker sneaker)
        {
            if (sneaker.IsFavorite)
            {
                sneaker.IsFavorite = false;
            }
            else
            {
                sneaker.IsFavorite = true;
            }
        }

        public Binding ReceiveSneakers = new Binding(nameof(Sneakers));
        public Binding IsFavorite = new Binding(nameof(Sneaker.IsFavorite));
    }
}
