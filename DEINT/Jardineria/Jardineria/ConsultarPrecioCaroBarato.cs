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
    public partial class ConsultarPrecioCaroBarato : Form
    {
        Conexion conexion;
        public ConsultarPrecioCaroBarato()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        private void ConsultarPrecioCaroBarato_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = conexion.EjecutarSentencia($"select max(precio_venta),min(precio_venta) from producto;");

                DataTable datos = ds.Tables[0];
                dataGridView1.DataSource = datos;
            }catch (SqlException)
            {
                MessageBox.Show("Acceso erróneo a la base de datos");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
