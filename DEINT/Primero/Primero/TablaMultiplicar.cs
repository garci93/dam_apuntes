using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primero
{
    public partial class TablaMultiplicar : Form
    {
        public TablaMultiplicar()
        {
            InitializeComponent();
        }

        private void TablaMultiplicar_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

            }
            textBox1.AppendText(radioButton1.Checked.ToString());
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
