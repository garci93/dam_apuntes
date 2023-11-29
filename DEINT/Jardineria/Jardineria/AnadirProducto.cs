using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

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
                comboBoxGama.Items.Add(fila[0]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            conexion.EjecutarComandoSinRetornarDatos($"insert into producto (codigo_producto, nombre, gama, dimensiones, proveedor, descripcion, cantidad_en_stock, precio_venta, precio_proveedor) values ({int.Parse(textCodigo.Text)},'{textNombre.Text}','{comboBoxGama.Text}','{textDimensiones.Text}','{textProveedor.Text}','{textDescripcion.Text}',{int.Parse(textStock.Text)},{int.Parse(textPrecioVenta.Text)},{int.Parse(textPrecioProveedor.Text)})");
            Close();
        }

        private void textCodigo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex regex = new Regex(@"^\d+$");
            if (!regex.IsMatch(textCodigo.Text))
            {
                MessageBox.Show("El c�digo debe ser un n�mero v�lido");
            }
        }

        private void textStock_Validating(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^\d+$");
            if (!regex.IsMatch(textStock.Text))
            {
                MessageBox.Show("La cantidad debe ser un n�mero v�lido");
            }
        }

        private void textPrecioVenta_Validating(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^\d+$");
            if (!regex.IsMatch(textPrecioVenta.Text))
            {
                MessageBox.Show("El precio de venta debe ser un n�mero v�lido");
            }
        }

        private void textPrecioProveedor_Validating(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^\d+$");
            if (!regex.IsMatch(textPrecioProveedor.Text))
            {
                MessageBox.Show("El precio del proveedor debe ser un n�mero v�lido");
            }
        }
    }
}