using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoBBDD.DLL
{
    internal class PruebaDLL
    {
        private static PruebaDLL instance;
        private Conexion conexion;

        public PruebaDLL()
        {
            conexion = new Conexion();
        }

        public static PruebaDLL GetInstance()
        {
            if (instance == null)
            {
                instance = new PruebaDLL();
            }
            return instance;
        }

        public void anadirPrueba(int codigo, string prueba)
        {
            conexion.EjecutarComandoSinRetornarDatos($"INSERT INTO prueba(codigo, prueba) VALUES({codigo}, '{prueba}')");
        }

        public void modificarPrueba(int codigo, string prueba)
        {
            conexion.EjecutarComandoSinRetornarDatos($"UPDATE prueba SET prueba='{prueba}' WHERE codigo={codigo}");
        }

        public void borrarPrueba(int codigo)
        {
            conexion.EjecutarComandoSinRetornarDatos($"DELETE FROM prueba WHERE codigo={codigo}");
        }

        public DataSet mostrarPruebas()
        {
            return conexion.EjecutarSentencia("SELECT * FROM prueba");
        }
    }
}
