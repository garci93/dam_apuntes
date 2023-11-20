namespace Serializacion_Ej
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            Anadir anadir = new Anadir();
            anadir.ShowDialog();
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
            Mostrar mostrar = new Mostrar();
            mostrar.ShowDialog();
        }
    }
}