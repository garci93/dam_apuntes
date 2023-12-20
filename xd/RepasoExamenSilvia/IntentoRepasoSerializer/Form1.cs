namespace IntentoRepasoSerializer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCrearProyecto_Click(object sender, EventArgs e)
        {
            CrearProyectoForm form = new CrearProyectoForm();
            form.ShowDialog();
        }

        private void buttonAgregarTareas_Click(object sender, EventArgs e)
        {
            AgregarTareaForm form = new AgregarTareaForm();
            form.ShowDialog();
        }

        private void buttonVisualizar_Click(object sender, EventArgs e)
        {
            VisualizarInfoForm form = new VisualizarInfoForm();
            form.ShowDialog();
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            ExportarProyecto ex = new ExportarProyecto();
            ex.ShowDialog();
        }
    }
}
