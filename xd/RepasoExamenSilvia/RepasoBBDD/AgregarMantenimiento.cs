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
    public partial class AgregarMantenimiento : Form
    {
        public AgregarMantenimiento()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            MantenimientoDLL.GetInstance().agregarMantenimiento(int.Parse(textBox1.Text), textBox2.Text, int.Parse(textBox3.Text), textBox4.Text, textBox5.Text, textBox6.Text);
        }
    }
}
