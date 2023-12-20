using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntentoRepasoSerializer
{
    public partial class CrearProyectoForm : Form
    {
        public CrearProyectoForm()
        {
            InitializeComponent();
            
        }

        private void buttonCrearProyecto_Click(object sender, EventArgs e)
        {
            CrearDirectorio();
        }

        public void CrearDirectorio()
        {
            Directory.CreateDirectory("Directorio1");
        }
    }
}
