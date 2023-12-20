using RepasoBBDD.DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoBBDD
{
    public partial class VisualizarMantenimiento : Form
    {
        public VisualizarMantenimiento()
        {
            InitializeComponent();
            dataGridView1.DataSource = MantenimientoDLL.GetInstance().visualizarMantenimiento().Tables[0];
        }
       

        private void VisualizarMantenimiento_Load(object sender, EventArgs e)
        {

        }
    }
}
