using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoSerializ
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
            tareas.Add(new Tarea("Tarea 1", "Descripción 1", DateTime.Now, TipoEstado.PENDIENTE));
            tareas.Add(new Tarea("Tarea 2", "Descripción 2", DateTime.Now, TipoEstado.COMPLETADA));
            Proyecto p = new Proyecto("Primer proyecto", "Descripción", DateTime.Now, tareas);
            p.SerializarProyecto();
            p.SerializarProyectoJSON();

            Proyecto pro = p.DeserializarProyecto();
            Proyecto proj = p.DeserializarProyectoJSON();
            label1.Text = proj.Nombre;
            label2.Text = proj.Descripcion;

            dataGridView1.DataSource = pro.Lista;
            p.ExportarProyecto();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
