using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Banco
    {
        /*Banco: tiene un atributo que será un array de tamaño 3 de objetos de tipo Cliente.
        Tendrá un método Operar, que permitirá llamar a los métodos Ingresar y Extraer
        de los clientes. Para ello nos solicitará el cliente sobre el DNI sobre el que
        queremos operar, la operación a realizar y la cantidad. También banco debe tener
        otro método que “al final del día” calcule la cantidad de dinero que hay
        depositada.*/


        public Banco()
        {
            Cliente[] clientes = InicializarClientes(3);
        }



        Cliente[] InicializarClientes(int cantidad)
        {
            Cliente[] clientes = new Cliente[cantidad];
            for (int i = 0; i < cantidad; ++i)
            {
                clientes[i] = new Cliente();
            }

            return clientes;
        }

        public void Operar(Cliente[] clientes)
        {
            Console.WriteLine("Introduzca el DNI");
            string dni = Console.ReadLine();
            Console.WriteLine("Pulse 1 para ingresar o 2 para extraer");
            int opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca la cantidad");
            int cantidad = int.Parse(Console.ReadLine());
            clientes.Where(cliente => cliente.DNI == dni);
        }

        //"al final del dia" osea sumar el dinero de todas las cuentas
    }
}
