namespace AsincronismoDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            pictureBox1.Visible = true;
            await RealizarProcesamientoLargo();

            var nombre = await ObtenerNombre();
            MessageBox.Show($"Hola, {nombre}");
            pictureBox1.Visible = false;

        }

        private async Task RealizarProcesamientoLargo()
        {
            await Task.Delay(500);
        }

        private async Task<string> ObtenerNombre()
        {
            await Task.Delay(100);
            return ("Cecilia");
        }
    }
}