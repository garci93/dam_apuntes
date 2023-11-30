using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            string mes = monthCalendar1.SelectionStart.Month.ToString("00");
            string anio = monthCalendar1.SelectionStart.Year.ToString();
            conexion.EjecutarSentencia($"select * from pedidos where fecha_entrega = '{anio}-{mes}-");
        }
    }
}
