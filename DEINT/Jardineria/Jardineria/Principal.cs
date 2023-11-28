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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnAnadirProducto_Click(object sender, EventArgs e)
        {
            AnadirProducto anadirProducto = new AnadirProducto();
            anadirProducto.ShowDialog();
        }

        private void btnConsultarEmpleadosJefe_Click(object sender, EventArgs e)
        {
            ConsultarEmpleados consultarEmpleados = new ConsultarEmpleados();
            consultarEmpleados.ShowDialog();
        }

        private void btnConsultarPedidosEntregados_Click(object sender, EventArgs e)
        {
            ConsultarPedidosEntregados consultarPedidosEntregados = new ConsultarPedidosEntregados();
            consultarPedidosEntregados.ShowDialog();
        }

        private void btnConsultarClientesNoPagan_Click(object sender, EventArgs e)
        {
            ConsultarClientesNoPagan consultarClientesNoPagan = new ConsultarClientesNoPagan();
            consultarClientesNoPagan.ShowDialog();
        }

        private void btnConsultarPrecioCaroBarato_Click(object sender, EventArgs e)
        {
            ConsultarPrecioCaroBarato consultarPrecioCaroBarato = new ConsultarPrecioCaroBarato();
            consultarPrecioCaroBarato.ShowDialog();
        }

        private void btnEliminarGama_Click(object sender, EventArgs e)
        {
            EliminarGama eliminarGama = new EliminarGama();
            eliminarGama.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
