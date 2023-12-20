using Recup.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Recup
{
    public partial class CrearEditorial : Form
    {
        public Conexion.Conexion conexion = new Conexion.Conexion();
        public Form frm = new Form();
        public CrearEditorial()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            conexion.EjecutarComandoSinRetornarDatos($"INSERT INTO dbo.Editorial(codigo,nombre,direccion) VALUES ({int.Parse(txtCodigo.Text)},'{txtNombre.Text}','{txtDireccion.Text}')");
            Close();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Regex reg = new Regex(@"^\d{2}$");
                if (!reg.IsMatch(txtCodigo.Text)) throw new FormatException();
            }
            catch (FormatException)
            {

            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Regex reg = new Regex(@"^\w+$");
                if (!reg.IsMatch(txtNombre.Text)) throw new FormatException();
            }
            catch (FormatException)
            {
                
            }
        }


        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Regex reg = new Regex(@"^\w+$");
                if (!reg.IsMatch(txtDireccion.Text)) throw new FormatException();
            }
            catch (FormatException)
            {

            }
        }
        
    }
}
