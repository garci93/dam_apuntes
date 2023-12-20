namespace RepasoBBDD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAgregarVehiculos_Click(object sender, EventArgs e)
        {
            AgregarVehiculosForm formularioAnadir = new AgregarVehiculosForm();
            formularioAnadir.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModificarEstado mod = new ModificarEstado();
            mod.ShowDialog();
        }

        private void buttonVisualizarInventarioVehi_Click(object sender, EventArgs e)
        {
            VisualizarVehiculos vis = new VisualizarVehiculos();
            vis.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AgregarMantenimiento ag = new AgregarMantenimiento();
            ag.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VisualizarMantenimiento vis = new VisualizarMantenimiento();
            vis.ShowDialog();
        }

        private void buttonPruebaRepaso_Click(object sender, EventArgs e)
        {
            PruebaForm formulario = new PruebaForm();
            formulario.ShowDialog();
        }
    }
}
