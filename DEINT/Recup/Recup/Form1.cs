using System.Data;

namespace Recup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Biblioteca b = Biblioteca.GetInstance();
            b.DeserializarLibros();
            dataGridView1.DataSource = b;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Biblioteca b = Biblioteca.GetInstance();
            b.SerializarLibros();
        }

        private void btnCrearLibro_Click(object sender, EventArgs e)
        {
            Form frm = new CrearLibro();
            frm.ShowDialog();
        }

        private void btnCrearEditorial_Click(object sender, EventArgs e)
        {
            Form frm = new CrearEditorial();
            frm.ShowDialog();
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            Form frm = new EliminarLibro();
            frm.ShowDialog();
        }

        private void btnEliminarEditorial_Click(object sender, EventArgs e)
        {
            Form frm = new EliminarEditorial();
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizarLibro_Click(object sender, EventArgs e)
        {
            Form frm = new ModificarLibro();
            frm.ShowDialog();
        }
    }
}
