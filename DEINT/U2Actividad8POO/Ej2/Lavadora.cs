using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2Actividad8POO
{
    internal class Lavadora : Electrodomestico
    {
        private const int cargaPorDefecto = 5;
        public Lavadora() {
            PrecioBase = base.PrecioBase;
            Color = base.Color;
            Consumo = base.Consumo;
            Peso = base.Peso;
            Carga = cargaPorDefecto;
        }
        public Lavadora(double precio_base,int peso)
        {
            PrecioBase = precio_base;
            Color = base.Color;
            Consumo = base.Consumo;
            Peso = peso;
            Carga = cargaPorDefecto;
        }
        public Lavadora(double precio_base, string color, char consumo, int peso, int carga)
            : base(precio_base,color,consumo,peso)
        {
            Carga = carga;
        }
        public int Carga {  get; set; }

        public double PrecioFinal()
        {
            double precioFinal = base.PrecioFinal();
            if (Carga > 30) precioFinal += 50;

            return precioFinal;
        }
    }
}
