using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenJunio.MVVM.Models
{
    public class Sneaker
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public bool IsFavorite { get; set; }

        public Sneaker(string brand, string color, double price, string image, bool isFavorite)
        {
            Brand = brand;
            Color = color;
            Price = price;
            Image = image;
            IsFavorite = isFavorite;
        }

        public string ToStringName()
        {
            return $"{Brand} {Color}";
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

        public string ToStringPrice()
        {
            return $"{Price}";
        }
    }
}
