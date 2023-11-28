using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Jardineria
{
    public partial class AnadirProducto : Form
    {
        Conexion conexion;
        public AnadirProducto()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AnadirProducto_Load(object sender, EventArgs e)
        {
            DataSet ds = conexion.EjecutarSentencia("select gama from gama_producto");
            DataTable datos = ds.Tables[0];
            foreach (DataRow fila in datos.Rows)
            {
                Console.WriteLine("Valor de la columna Nombre: " + fila[0]);
                comboBox1.Items.Add(fila[0]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}