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
    public partial class PruebaForm : Form
    {
        public PruebaForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = PruebaDLL.GetInstance().mostrarPruebas().Tables[0];
        }

        private void buttonAgregarPrueba_Click(object sender, EventArgs e)
        {
            PruebaDLL.GetInstance().anadirPrueba(int.Parse(textBoxCodigo.Text), textBoxPrueba.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            PruebaDLL.GetInstance().modificarPrueba(int.Parse(textBoxCodigo.Text), textBoxPrueba.Text);
        }

        private void buttonBorrarPrueba_Click(object sender, EventArgs e)
        {
            PruebaDLL.GetInstance().borrarPrueba(int.Parse(textBoxCodigo.Text));
        }
    }
}
