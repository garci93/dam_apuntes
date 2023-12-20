using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoBBDD.DLL
{
    internal class VehiculoDLL
    {
        private static VehiculoDLL instance;
        private Conexion conexion;

        private VehiculoDLL() 
        {
            conexion = new Conexion();
        }
        public static VehiculoDLL GetInstance()
        {
            if(instance == null)
            {
                instance = new VehiculoDLL();
            }
            return instance;
        }

        public void anadirVehiculo(int codigo, string matricula,string modelo, string marca,int año, string estado)
        {
            conexion.EjecutarComandoSinRetornarDatos($"INSERT INTO vehiculo(codigo,matricula,modelo,marca,año_fabricacion,estado) VALUES({codigo},'{matricula}','{modelo}','{marca}',{año},'{estado}')");
        }
        public void modificarVehiculo(int codigo, string matricula, string modelo, string marca, int año, string estado)
        {
            conexion.EjecutarComandoSinRetornarDatos($"UPDATE vehiculo SET matricula='{matricula}', modelo='{modelo}', marca='{marca}', año_fabricacion={año}, estado='{estado}' WHERE codigo = {codigo}");
        }

        public DataSet visualizarVehiculos()
        {
            return conexion.EjecutarSentencia("SELECT * FROM vehiculo");
        }

    }
}
