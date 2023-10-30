using System.Text.RegularExpressions;

namespace U3_E2_Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            label1.BackColor = Color.Red;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label3.BackColor = Color.Red;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label4.BackColor = Color.Red;
        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex regex = new Regex(@"^\d{8}\-?[A-Z]$");
            if (!regex.IsMatch(sender.ToString()))
            {
                MessageBox.Show("El DNI debe contener ocho cifras seguidas de una letra mayúscula");
                e.Cancel = true;
            }
        }
        private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (sender.ToString().Length == 0)
            {
                MessageBox.Show("El nombre no puede estar vacío");
                e.Cancel = true;
            }
        }
        private void textBox3_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (sender.ToString().Length == 0)
            {
                MessageBox.Show("El apellido no puede estar vacío");
                e.Cancel = true;
            }
        }
        private void textBox4_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex regex = new Regex(@"^\w+(\.\w)*\@\w(\.\w)*\.\w+$");
            if (!regex.IsMatch(sender.ToString()))
            {
                MessageBox.Show("El email no tiene el formato correcto");
                e.Cancel = true;
            }
        }
    }
}