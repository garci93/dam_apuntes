using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminIES.DLL
{
    class EstudianteDLL
    {
        Conexion conexion;
        public EstudianteDLL()
        {
            conexion = new Conexion();
        }
        public bool Agregar(string nombre,string primerApellido, string segundoApellido, string correo, string ciclo)
        {
            return conexion.EjecutarComandoSinRetornarDatos("Insert into Estudiante(nombre,primerApellido,segundoApellido,correo) values ('" + nombre
                + "','" + primerApellido
                + "','" + segundoApellido
                + "','" + correo
                + "')") &&
                conexion.EjecutarComandoSinRetornarDatos("Insert into Estudiante(nombre,primerApellido,segundoApellido,correo) values ('" + nombre
                + "','" + primerApellido
                + "','" + segundoApellido
                + "','" + correo
                + "')");
            //to do: crear registro que relacione ambas tablas
        }

        internal bool Modificar(string clave, string nombre, string primerApellido, string segundoApellido, string correo)
        {
            return conexion.EjecutarComandoSinRetornarDatos("Update Estudiante Set nombre = '" + nombre
                + "',primerApellido = '" + primerApellido
                + "',segundoApellido = '" + segundoApellido
                + "',correo = '" + correo
                + "' Where id = " + clave);
            //to do: modificar registro que relacione ambas tablas
        }

        internal bool Borrar(string id)
        {
            return conexion.EjecutarComandoSinRetornarDatos("Delete From Estudiante Where id = " + id);
        }

        public DataSet MostrarEstudiantes()
        {
            SqlCommand sentencia = new SqlCommand("Select * from estudiante");
            return conexion.EjecutarSentencia(sentencia);
        }
    }
}
