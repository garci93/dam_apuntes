using System.Text.RegularExpressions;

namespace Serializacion_Ej
{
    public partial class Form1 : Form
    {
        Banco banco = new Banco();
        public Form1()
        {
            InitializeComponent();
        }


        private void btnAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                bool res = Regex.IsMatch(txtDNI.Text, @"^\d{8}[A-Z]$") &&
                Regex.IsMatch(txtNombre.Text, @"^\w*$") &&
                Regex.IsMatch(txtDireccion.Text, @"^\w*$") &&
                Regex.IsMatch(txtEdad.Text, @"^\d+$") &&
                Regex.IsMatch(txtTelefono.Text, @"^((\+34)|(\+0034))?\d{9}$") &&
                Regex.IsMatch(txtCC.Text, @"^\d{16}$");
                if (res)
                {
                    Cliente cliente = new Cliente(txtDNI.Text, txtNombre.Text, txtDireccion.Text, int.Parse(txtEdad.Text), int.Parse(txtTelefono.Text), long.Parse(txtCC.Text));
                    banco.addClienteJSON(cliente);
                    cliente.GuardarEnArchivo("datos_cliente.bin");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Los datos introducidos no son correctos, por favor revíselos");
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar modificar = new Modificar();
            modificar.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar eliminar = new Eliminar();
            eliminar.ShowDialog();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}