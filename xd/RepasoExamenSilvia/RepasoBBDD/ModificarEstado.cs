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
    public partial class ModificarEstado : Form
    {
        public ModificarEstado()
        {
            InitializeComponent();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            VehiculoDLL.GetInstance().modificarVehiculo(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, int.Parse(textBox5.Text), textBox6.Text);
        }
    }
}
