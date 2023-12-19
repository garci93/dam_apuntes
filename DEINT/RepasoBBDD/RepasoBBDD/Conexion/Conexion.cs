﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoBBDD.Conexion
{
    internal class Conexion
    {
        //private string cadenaConexion = "Data Source=DAM2-19; Initial Catalog=jardineria; Integrated Security = True";
        private string cadenaConexion2 = "Data Source=DESKTOP-N0FOBBJ; Initial Catalog=examen; Integrated Security = True";
        SqlConnection sqlConnection;

        public SqlConnection EstablecerConexion()
        {
            //sqlConnection = new SqlConnection(cadenaConexion);
            sqlConnection = new SqlConnection(cadenaConexion2);
            return sqlConnection;
        }
        public bool EjecutarComandoSinRetornarDatos(string strComando)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = strComando;
                sqlCommand.Connection = EstablecerConexion();
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public DataSet EjecutarSentencia(string sqlComando)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = sqlComando;
                sqlCommand.Connection = EstablecerConexion();
                adapter.SelectCommand = sqlCommand;
                sqlConnection.Open();
                adapter.Fill(ds);
                sqlConnection.Close();
                return ds;
            }
            catch (Exception e)
            {
                return ds;
            }
        }
    }
}