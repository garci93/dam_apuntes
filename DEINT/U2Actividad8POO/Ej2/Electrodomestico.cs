using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2Actividad8POO
{
    internal class Electrodomestico
    {
        protected double PrecioBase { get; set; }
        protected string Color {  get; set; }
        protected char Consumo { get; set; }
        protected int Peso {  get; set; }

        public Electrodomestico()
        {
            PrecioBase = 100;
            Color = "Blanco";
            Consumo = 'F';
            Peso = 5;
        }

        public Electrodomestico(double precio_base, int peso)
        {
            PrecioBase = precio_base;
            Color = "Blanco";
            Consumo = 'F';
            Peso = peso;
        }
        public Electrodomestico (double precio_base, string color, char consumo, int peso)
        {
            PrecioBase = precio_base;
            Color = ComprobarColor(color);
            Consumo = ComprobarConsumoEnergia(consumo);
            Peso = peso;
        }

        private string ComprobarColor(string color)
        {
            color = color.ToLower();
            string[] coloresValidos = { "blanco","negro","rojo","azul","gris" };
            bool encontrado = false;
            foreach (var colorValido in coloresValidos)
            {
                if (color == colorValido)
                {
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado) color = "blanco";
            return color;
        }

        private char ComprobarConsumoEnergia(char letra)
        {
            char[] letrasValidas = { 'A','B','C','D','E','F','a','b','c','d','e','f' };
            bool encontrado = false;
            foreach (var letraValida in letrasValidas)
            {
                if (letra == letraValida)
                {
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado) letra = 'F';
            return letra;
        }

        public double PrecioFinal ()
        {
            double precioFinal = PrecioBase;
            switch (Consumo)
            {
                case 'A':
                case 'a':
                    precioFinal += 100;
                    break;
                case 'B':
                case 'b':
                    precioFinal += 80;
                    break;
                case 'C':
                case 'c':
                    precioFinal += 60;
                    break;
                case 'D':
                case 'd':
                    precioFinal += 50;
                    break;
                case 'E':
                case 'e':
                    precioFinal += 30;
                    break;
                case 'F':
                case 'f':
                    precioFinal += 10;
                    break;
            }

            if (0 <= Peso && Peso <= 19) precioFinal += 10;
            else if (Peso <= 49) precioFinal += 50;
            else if (Peso <= 79) precioFinal += 80;
            else precioFinal += 100;

            return precioFinal;
        }
    }
}
