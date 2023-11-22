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
                    Regex.IsMatch(txtDNI.Text, @"^\w*$") &&
                    Regex.IsMatch(txtDNI.Text, @"^\d+$") &&
                    Regex.IsMatch(txtDNI.Text, @"^((\+34)|(\+0034))?\d{9}$") &&;
                if ( )
                Cliente cliente = new Cliente(txtDNI.Text, txtNombre.Text, txtDireccion.Text, int.Parse(txtEdad.Text), int.Parse(txtTelefono.Text), int.Parse(txtCC.Text));
                banco.AgregarCliente(cliente);
                cliente.GuardarEnArchivo("datos_cliente.bin");
            } catch (Exception ex)
            {

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
    }
}