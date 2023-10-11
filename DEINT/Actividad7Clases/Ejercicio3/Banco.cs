using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Banco
    {

        Cliente[] clientes = { new Cliente("23468959A", "Pepe"), new Cliente("23905875E", "María"), new Cliente("84558453X", "Juan") };

        //Cliente[] InicializarClientes(int cantidad)
        //{
        //    Cliente[] clientes = new Cliente[cantidad];
        //    for (int i = 0; i < cantidad; ++i)
        //    {
        //        clientes[i] = new Cliente();
        //    }

        //    return clientes;
        //}

        public void Operar()
        {
            Console.WriteLine("Introduzca el DNI");
            string dni = Console.ReadLine();
            Console.WriteLine("Pulse 1 para ingresar o 2 para extraer");
            int opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca la cantidad");
            int cantidad = int.Parse(Console.ReadLine());
            if ( opcion == 1 )
            {
                clientes.First(cliente => cliente.DNI == dni).Ingresar(cantidad);

            } else if ( opcion == 2 )
            {
                clientes.First(cliente => cliente.DNI == dni).Extraer(cantidad);
            }
        }
        public void MostrarClientes()
        {
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine(cliente.ToString());
            }
        }

        public string Caja()
        {
            return "Saldo total: "+clientes.Select(cliente => cliente.CantidadAhorrada).Sum();
        }
    }
}
