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
    public partial class ConsultarClientesNoPagan : Form
    {
        Conexion conexion;
        public ConsultarClientesNoPagan()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ConsultarClientesNoPagan_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = conexion.EjecutarSentencia($"select * from cliente where codigo_cliente in (select codigo_cliente from pedido) and codigo_cliente not in (select codigo_cliente from pago);");

                DataTable datos = ds.Tables[0];
                dataGridView1.DataSource = datos;
            }
            catch (SqlException)
            {
                MessageBox.Show("Acceso erróneo a la base de datos");
            }
        }
    }
}
