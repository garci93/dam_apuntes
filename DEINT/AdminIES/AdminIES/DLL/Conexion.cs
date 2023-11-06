using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminIES.DLL
{
    class Conexion
    {
        private string cadenaConexion = "Data Source=DAM2-13; Initial Catalog=db.Sistema; Integrated Security = True";
        SqlConnection sqlConnection;

        public SqlConnection EstablecerConexion()
        {
            this.sqlConnection = new SqlConnection(this.cadenaConexion);
            return this.sqlConnection;
        }
        public bool EjecutarComandoSinRetornarDatos(string strComando)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = strComando;
                sqlCommand.Connection = this.EstablecerConexion();
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
