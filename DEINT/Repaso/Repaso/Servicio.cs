using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    internal class Servicio
    {
        private DAOPersonas dao = DAOPersonas.GetInstance();
        private static Servicio instance;

        private Servicio() {}

        public static Servicio GetInstance()
        {
            if (instance == null) instance = new Servicio();
            return instance;
        }

        public void AgregarPersona(string nombre, int edad)
        {
            dao.AgregarPersona(new Persona(nombre, edad));
        }

        public void EliminarPersona(string nombre) {
            dao.EliminarPersona(nombre);
        }

        public DataSet GetPersonas()
        {
            return dao.GetPersonas();
        }
    }

}
