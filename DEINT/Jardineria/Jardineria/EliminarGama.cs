using Jardineria.DLL;
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
    public partial class EliminarGama : Form
    {
        Conexion conexion;
        public EliminarGama()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        private void btnEliminarGama_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea Eliminar el contenido?", "Eliminar", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {

                JardineriaDLL jardineriaDLL = new JardineriaDLL();
                comboBoxGama.SelectedText.ToString();
                jardineriaDLL.eliminarGama(comboBoxGama.SelectedItem.ToString());
                MessageBox.Show("Se ha eliminado correctamente");
                EliminarGama_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Se ha producido un error al eliminar");
            }
            Close();
        }

        private void EliminarGama_Load(object sender, EventArgs e)
        {
            DataSet ds = conexion.EjecutarSentencia("select * from gama_producto");
            DataTable datos = ds.Tables[0];
            foreach (DataRow fila in datos.Rows)
            {
                Console.WriteLine("Valor de la columna Nombre: " + fila[0]);
                comboBoxGama.Items.Add(fila[0]);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxGama_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = conexion.EjecutarSentencia("select * from gama_producto");
            DataTable datos = ds.Tables[0];
            dataGridView1.DataSource = datos.Rows[comboBoxGama.SelectedIndex];
        }
    }
}
