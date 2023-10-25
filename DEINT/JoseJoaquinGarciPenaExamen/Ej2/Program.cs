using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ej2
{
    internal class Program
    {
        static int cantidad;
        static List<Perecedero> productosP = new List<Perecedero>();
        static List<NoPerecedero> productosNP = new List<NoPerecedero>();
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuántos productos perecederos desea crear?");
            try
            {
                cantidad = Console.Read();
                if (cantidad < 0) throw new ArgumentOutOfRangeException();
            }
            catch (FormatException)
            {
                Console.WriteLine("Debe introducir un número válido");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Debe introducir un número no negativo");
            }
            for (int i = 0; i < cantidad; i++)
            {
                productosP.Add(CrearPerecedero());
            }
            Console.WriteLine("¿Cuántos productos no perecederos desea crear?");
            try
            {
                cantidad = Console.Read();
                if (cantidad < 0) throw new ArgumentOutOfRangeException();
            }
            catch (FormatException)
            {
                Console.WriteLine("Debe introducir un número válido");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Debe introducir un número no negativo");
            }
            for (int i = 0; i < cantidad; i++)
            {
                productosNP.Add(CrearNoPerecedero());
            }



        }

        public static Producto MasCaro(Producto[] productos)
        {
            return productos.MaxBy(p => p.Precio);
        }

        public static Perecedero CrearPerecedero()
        {
            Console.WriteLine("Introduzca código del producto");
            string codigo = Console.ReadLine();
            Console.WriteLine("Introduzca nombre del producto");
            string nombre = Console.ReadLine();
            Console.WriteLine("Introduzca precio del producto");
            double precio;
            precio = Console.Read();
            if (precio < 0) throw new ArgumentOutOfRangeException("El precio no puede ser negativo");
            Console.WriteLine("Introduzca número de días para caducar");
            int diasACaducar = Console.Read();
            if (precio == null)
                return new Perecedero(codigo, nombre, diasACaducar);
            else
                return new Perecedero(codigo, nombre, precio, diasACaducar);
        }

        public static NoPerecedero CrearNoPerecedero()
        {
            Console.WriteLine("Introduzca código del producto");
            string codigo = Console.ReadLine();
            Console.WriteLine("Introduzca nombre del producto");
            string nombre = Console.ReadLine();
            Console.WriteLine("Introduzca precio del producto");
            double precio;
            precio = Console.Read();
            if (precio < 0) throw new ArgumentOutOfRangeException("El precio no puede ser negativo");
            Console.WriteLine("Introduzca tipo del producto");
            string tipo = Console.ReadLine();
            if (precio == null)
                return new NoPerecedero(codigo, nombre, tipo);
            else
                return new NoPerecedero(codigo, nombre, precio, tipo);
        }

        public static int CuantosCaducanMañana ()
        {
            return productosP.Count(p => p.DiasACaducar == 1);
        }

        public static List<Perecedero> OrdenadosPorCaducidad()
        {
            return productosP.OrderByDescending(p => p.DiasACaducar).ToList();
        }

        public static List<NoPerecedero> OrdenadosPorTipo()
        {
            return productosNP.GroupBy(p => p.Tipo).ToList().ToArray();
        }
    }
}

