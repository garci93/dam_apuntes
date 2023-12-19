using RepasoExamRecuDEINT.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    internal class DAOPersonas
    {
        private static DAOPersonas instance;
        private Conexion conexion;

        private DAOPersonas()
        {
            this.conexion = new Conexion();
        }

        public static DAOPersonas GetInstance()
        {
            if (instance == null) instance = new DAOPersonas();
            return instance;
        }

        public void AgregarPersona(Persona p)
        {
            conexion.EjecutarComandoSinRetornarDatos("INSERT INTO personas (nombre,edad) " +
                "VALUES('" + p.Nombre + "'," + p.Edad + ")");
        }

        public void EliminarPersona(string nombre)
        {
            conexion.EjecutarComandoSinRetornarDatos("DELETE FROM personas WHERE nombre='" + nombre + "'");
        }

        public DataSet GetPersonas()
        {
            return conexion.EjecutarSentencia("SELECT * FROM personas");
        }
    }
}
