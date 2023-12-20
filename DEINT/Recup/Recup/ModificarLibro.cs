using Recup.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recup
{
    public partial class ModificarLibro : Form
    {
        public Conexion.Conexion conexion = new Conexion.Conexion();
        public Form frm = new Form();
        public ModificarLibro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.EjecutarComandoSinRetornarDatos($"UPDATE dbo.Libro SET (isbn={int.Parse(txtISBN.Text)},titulo='{txtTitulo.Text}',autor='{txtAutor.Text}',año_publicacion={int.Parse(txtAnio.Text)},cod_editorial={int.Parse(txtCodigoEd.Text)},genero='{comboBox1.SelectedItem}') WHERE isbn={int.Parse(txtISBN.Text)}");
            Close();
        }

        private void ModificarLibro_Load(object sender, EventArgs e)
        {

        }
    }
}
