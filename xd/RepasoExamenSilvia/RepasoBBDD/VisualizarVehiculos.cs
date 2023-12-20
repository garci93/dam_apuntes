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
    public partial class VisualizarVehiculos : Form
    {
        public VisualizarVehiculos()
        {
            InitializeComponent();
            dataGridView1.DataSource = VehiculoDLL.GetInstance().visualizarVehiculos().Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
