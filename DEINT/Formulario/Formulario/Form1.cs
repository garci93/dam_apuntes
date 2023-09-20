namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (rbtn1.Checked == false)
            {
                rbtn1.Enabled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = textBox1.Text;
            double salario = Convert.ToDouble(textBox2.Text);
            double descuento,descontado,liquido;
            String tipo;
            if (rbtn1.Checked || rbtn2.Checked || rbtn3.Checked)
            {
                if (rbtn1.Checked)
                {
                    descuento = 0.2;
                    tipo = "Gerente";
                }
                else
                {
                    if (rbtn2.Checked)
                    {
                        descuento = 0.15;
                        tipo = "SubGerente";
                    }
                    else
                    {
                        descuento = 0.05;
                        tipo = "Secretaria";
                    }
                }
                descontado = salario * descuento;
                liquido = salario - descontado;
                MessageBox.Show("Tipo de empleado: " + tipo + "\nSalario bruto: " + salario + "\nDescuento: " + descontado + "\nSalario líquido: " + liquido, "Respuesta");
            }
        }
    }
}