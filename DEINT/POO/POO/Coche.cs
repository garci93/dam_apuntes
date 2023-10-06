using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Coche
    {

        //los campos empiezan con _ y son privados
        internal string _marca;
        int _año;
        string _modelo;

        //prop TAB: te crea una propiedad
        internal string Modelo
        {
            get { return _modelo.ToUpper(); } //Siempre se devolverá el modelo en mayúsculas
            set { _modelo = value; }
        }

        internal int Año { get; set; }
        internal int Año2 { get; set; } = 1990; //Asignarle un valor por defecto? Si es así el campo arriba no hace falta. Se puede modificar desde fuera con el set

        internal int Velocidad { get; private set; } = 20; //Lo mismo PERO no se puede acceder desde fuera de la clase
        internal void Detener() => Velocidad = 0; //Función lambda

        //internal void Acelerar()
        //{
        //    Acelerar(1);
        //}

        //CONSTRUCTOR ctor tab tab

        internal Coche() : this("marca por defecto")
        {
            Console.WriteLine("Instanciando un coche");
        }

        internal Coche(string marca)
        {
            Console.WriteLine("Instanciando un coche con una marca");
            _marca = marca;
        }
    }
}
