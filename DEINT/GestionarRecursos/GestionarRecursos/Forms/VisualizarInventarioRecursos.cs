using GestionarRecursos.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionarRecursos.Forms
{
    public partial class VisualizarInventarioRecursos : Form
    {
        Conexion.Conexion conexion;
        public VisualizarInventarioRecursos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VisualizarInventarioRecursos_Load(object sender, EventArgs e)
        {
            conexion = new Conexion.Conexion();
            DataSet ds = new DataSet(conexion.EjecutarComandoSinRetornarDatos($"select * from recurso_tecnologico;")); ;

            DataTable datos = ds.Tables[0];
            foreach (DataRow dr in datos.Rows)
            {
                dataGridView1.Rows.Add(dr);
            }
        }
    }
}
