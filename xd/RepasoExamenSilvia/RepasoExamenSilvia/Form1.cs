namespace RepasoExamenSilvia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Tarea> tareas = new List<Tarea>();
            tareas.Add(new Tarea("Tarea1", "Descripcion1", DateTime.Now, TipoEstado.COMPLETADA));
            tareas.Add(new Tarea("Tarea2", "Descripcion2", DateTime.Now, TipoEstado.PENDIENTE));
            tareas.Add(new Tarea("Tarea3", "Descripcion3", DateTime.Now, TipoEstado.EN_PROGRESO));

            Proyecto proyecto = new Proyecto("Primer Proyecto", "Descripcion1", DateTime.Now, tareas);

            proyecto.SerializarProyecto();
            proyecto.SerializarProyectoJSON();

            //Proyecto p = proyecto.DeserializarProyecto();
            Proyecto p = proyecto.DeserializarProyectoJSON();

            label1.Text = p.Nombre;
            label2.Text = p.Descripcion;

            dataGridView1.DataSource = p.Lista;

            proyecto.ExportarProyecto();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
