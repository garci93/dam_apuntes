using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RepasoBBDD.DLL
{
    internal class MantenimientoDLL
    {
        private static MantenimientoDLL instance;
        private Conexion conexion;

        private MantenimientoDLL()
        {
            conexion = new Conexion();
        }
        public static MantenimientoDLL GetInstance()
        {
            if (instance == null)
            {
                instance = new MantenimientoDLL();
            }
            return instance;
        }

        public void agregarMantenimiento(int codigo, string cod_descripcion, int codigo_vehiculo,string fecha_inicio, string fecha_fin, string descripcion )
        {
            conexion.EjecutarComandoSinRetornarDatos($"INSERT INTO mantenimiento(codigo,cod_descripcion,codigo_vehiculo,fecha_inicio,fecha_fin,descripcion) VALUES({codigo},'{cod_descripcion}',{codigo_vehiculo},'{fecha_inicio}','{fecha_fin}','{descripcion}')");
        }

        public DataSet visualizarMantenimiento()
        {
            return conexion.EjecutarSentencia("SELECT * FROM mantenimiento");
        }
    }
}
