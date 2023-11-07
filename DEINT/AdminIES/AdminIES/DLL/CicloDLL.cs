using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminIES.DLL
{
    class CicloDLL
    {
        Conexion conexion;
        public CicloDLL()
        {
            conexion = new Conexion();
        }
        public bool Agregar(string nombreCiclo)
        {
            return conexion.EjecutarComandoSinRetornarDatos("Insert into Ciclo(nombre) values ('" + nombreCiclo + "')");
        }

        internal bool Modificar(string id, string nombreCiclo)
        {
            return conexion.EjecutarComandoSinRetornarDatos("Update Ciclo Set nombre = '" + nombreCiclo + "' Where id = " + id);
        }

        internal bool Borrar(string id)
        {
            return conexion.EjecutarComandoSinRetornarDatos("Delete From Ciclo Where id = " + id);
        }

        public DataSet MostrarCiclos()
        {
            SqlCommand sentencia = new SqlCommand("Select * from ciclo");
            return conexion.EjecutarSentencia(sentencia);
        }
    }
}
