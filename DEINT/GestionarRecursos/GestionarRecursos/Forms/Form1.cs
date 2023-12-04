using GestionarRecursos.Forms;

namespace GestionarRecursos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarRecurso_Click(object sender, EventArgs e)
        {
            AgregarRecurso agregarRecurso = new AgregarRecurso();
            agregarRecurso.ShowDialog();
        }

        private void btnModificarRecurso_Click(object sender, EventArgs e)
        {
            ModificarEstadoRecurso modificarEstadoRecurso = new ModificarEstadoRecurso();
            modificarEstadoRecurso.ShowDialog();
        }

        private void btnVisualizarInventarioRecursos_Click(object sender, EventArgs e)
        {
            VisualizarInventarioRecursos visualizarInventarioRecursos = new VisualizarInventarioRecursos();
            visualizarInventarioRecursos.ShowDialog();
        }

        private void btnAgregarMantenimiento_Click(object sender, EventArgs e)
        {
            AgregarMantenimiento agregarMantenimiento = new AgregarMantenimiento();
            agregarMantenimiento.ShowDialog();
        }

        private void btnVisualizarMantenimientos_Click(object sender, EventArgs e)
        {
            VisualizarMantenimientos visualizarMantenimientos = new VisualizarMantenimientos();
            visualizarMantenimientos.ShowDialog();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
