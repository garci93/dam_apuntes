using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionarRecursos.DLL
{
    internal class GestionRecursosDLL
    {
        static Conexion.Conexion conexion;

        public static void agregarRecurso (string codigoRecurso, string nombre, string descripcion, int fecha, string estado)
        {
            conexion = new Conexion.Conexion();
            conexion.EjecutarComandoSinRetornarDatos($"insert into recurso_tecnologico values ('{codigoRecurso}','{nombre}','{descripcion}',{fecha},'{estado}');");
        }

        internal static void modificarEstadoRecurso(string codigoRecurso, string estado)
        {
            conexion = new Conexion.Conexion();
            conexion.EjecutarComandoSinRetornarDatos($"update recurso_tecnologico set estado='{estado}' where codigo_recurso='{codigoRecurso}';");
        }
    }
}
