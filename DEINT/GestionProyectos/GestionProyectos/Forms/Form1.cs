using GestionProyectos.Forms;

namespace GestionProyectos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CrearProyecto crear = new CrearProyecto();
            crear.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarTareas agregarTareas = new AgregarTareas();
            agregarTareas.Show();
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            VisualizarEstado visualizarEstado = new VisualizarEstado();
            visualizarEstado.Show();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarProyecto exportarProyecto = new ExportarProyecto();
            exportarProyecto.Show();
        }
    }
}
