using RepasoBBDD.DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoBBDD
{
    public partial class AgregarVehiculosForm : Form
    {
        public AgregarVehiculosForm()
        {
            InitializeComponent();
        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            VehiculoDLL.GetInstance().anadirVehiculo(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, int.Parse(textBox5.Text), textBox6.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(textBox2.Text, @"^[0-9]{4}[A-Z]{3}$"))
            {
                errorProvider1.SetError(textBox2,"Introduzca una matricula valida");
            }
        }
    }
}
