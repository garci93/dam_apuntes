using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AdminIES.DLL
{
    class EstudianteDLL
    {
        Conexion conexion;
        public EstudianteDLL()
        {
            conexion = new Conexion();
        }
        public bool Agregar(string nombre,string primerApellido, string segundoApellido, string email, string ciclo,Image foto)
        {
            return conexion.EjecutarComandoSinRetornarDatos("Insert into Estudiante(nombre,primerapellido,segundoapellido,email,ciclo,foto) values ('" + nombre
                + "','" + primerApellido
                + "','" + segundoApellido
                + "','" + email
                + "','" + ciclo
                + "','" + foto
                + "')");
        }

        internal bool Modificar(string clave, string nombre, string primerApellido, string segundoApellido, string email, string ciclo,Image foto
           )
        {
            return conexion.EjecutarComandoSinRetornarDatos("Update Estudiante Set nombre = '" + nombre
                + "',primerApellido = '" + primerApellido
                + "',segundoApellido = '" + segundoApellido
                + "',email = '" + email
                + "',ciclo = '" + ciclo
                + "',foto = '" + foto
                + "' Where id = " + clave);
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
