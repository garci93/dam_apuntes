using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardineria.DLL
{
    internal class JardineriaDLL
    {
        Conexion conexion;
        public JardineriaDLL()
        {
            conexion = new Conexion();
        }

        public bool eliminarGama(string gama)
        {
            return conexion.EjecutarComandoSinRetornarDatos($"Delete from gama_producto where gama = '{gama}' ");
        }
    }
}
