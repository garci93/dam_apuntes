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
    public partial class EliminarEditorial : Form
    {
        public Conexion.Conexion conexion = new Conexion.Conexion();
        public Form frm = new Form();
        public EliminarEditorial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.EjecutarComandoSinRetornarDatos($"DELETE FROM dbo.Editorial WHERE codigo={int.Parse(textBox1.Text)}");
            Close();
        }
    }
}
