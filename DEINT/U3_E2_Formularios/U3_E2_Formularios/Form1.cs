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
            Regex regex = new Regex(@"^\d{8}[A-Z]$");
            if (!regex.IsMatch(textBox1.Text.ToString()))
            {
                MessageBox.Show("El DNI debe contener ocho cifras seguidas de una letra mayúscula");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
        private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox2.Text.ToString().Length == 0)
            {
                MessageBox.Show("El nombre no puede estar vacío");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
        private void textBox3_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox3.Text.ToString().Length == 0)
            {
                MessageBox.Show("El apellido no puede estar vacío");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
        private void textBox4_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex regex = new Regex(@"^\w+(\.\w)*\@\w(\.\w)*\.\w+$");
            if (!regex.IsMatch(textBox4.Text.ToString()))
            {
                MessageBox.Show("El email no tiene el formato correcto");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Imagenes | *.jpg; *.gif";
            openFileDialog1.Title = "Seleccionar una imagen";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}