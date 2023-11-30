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
    public partial class ConsultarPedidosEntregados : Form
    {
        Conexion conexion;
        public ConsultarPedidosEntregados()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try { 
                string mes = monthCalendar1.SelectionStart.Month.ToString("00");
                string anio = monthCalendar1.SelectionStart.Year.ToString();
                DataSet ds = conexion.EjecutarSentencia($"select * from pedido where year(fecha_entrega) = {anio} and month(fecha_entrega) = {mes}");
                DataTable datos = ds.Tables[0];
                dataGridView1.DataSource = datos;
                ConsultarPedidosEntregados_Load(sender, e);
            }catch (SqlException)
                {
                    MessageBox.Show("Acceso erróneo a la base de datos");
                }
}

        private void ConsultarPedidosEntregados_Load(object sender, EventArgs e)
        {

        }
    }
}
