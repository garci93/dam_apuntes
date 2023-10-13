using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2Actividad8POO
{
    internal class Television : Electrodomestico
    {
        public Television()
        {
            PrecioBase = base.PrecioBase;
            Color = base.Color;
            Consumo = base.Consumo;
            Peso = base.Peso;
            Resolucion = 20;
            SintonizadorTDT = false;
        }
        public Television(double precio_base, int peso)
        {
            PrecioBase = precio_base;
            Color = base.Color;
            Consumo = base.Consumo;
            Peso = peso;
            Resolucion = 20;
            SintonizadorTDT = false;
        }
        public Television(double precio_base, string color, char consumo, int peso, int resolucion, bool sintonizadorTDT)
            : base(precio_base,color,consumo,peso) {
           Resolucion = resolucion;
           SintonizadorTDT = sintonizadorTDT;
        }
        public int Resolucion { get; set; }
        public bool SintonizadorTDT { get; set; }

        public double PrecioFinal()
        {
            double precioFinal = base.PrecioFinal();
            if (Resolucion >40) precioFinal += 0.3*precioFinal;
            if (SintonizadorTDT) precioFinal += 50;

            return precioFinal;
        }
    }
}
