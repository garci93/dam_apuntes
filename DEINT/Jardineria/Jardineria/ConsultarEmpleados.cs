using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jardineria
{
    public partial class ConsultarEmpleados : Form
    {
        Conexion conexion;
        public ConsultarEmpleados()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        private void ConsultarEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrarEmpleados_Click(object sender, EventArgs e)
        {
            try { 
                DataSet ds = conexion.EjecutarSentencia($"select * from empleado where codigo_jefe = {int.Parse(textCodigoJefe.Text)}");
                DataTable datos = ds.Tables[0];
                List<string> listaDatos = new List<string>();
                foreach (DataRow row in datos.Rows)
                {
                    string filaString = $"{row["nombre"]} {row["apellido1"]} {row["apellido2"]} {row["email"]}";
                    listaDatos.Add(filaString);

                }
                listBox1.DataSource = listaDatos;
                ConsultarEmpleados_Load(sender, e);
            }
            catch (SqlException)
            {
                MessageBox.Show("Acceso erróneo a la base de datos");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
