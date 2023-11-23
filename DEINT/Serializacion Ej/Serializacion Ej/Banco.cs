using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion_Ej
{
    [Serializable]
    internal class Banco
    {
        public List<Cliente> Clientes { get; set; }

        //Serializer


        // Constructor
        public Banco()
        {
            Clientes = new List<Cliente>();
        }
        public void AgregarCliente(Cliente nuevoCliente)
        {
            Clientes.Add(nuevoCliente);
        }
        //getInstance
        //seguir CRUD
        //guardarClient

    }
}
