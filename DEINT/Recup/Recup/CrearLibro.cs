using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Recup.Conexion.Conexion;

namespace Recup
{
    public partial class CrearLibro : Form
    {
        public Conexion.Conexion conexion = new Conexion.Conexion();
        public Form frm = new Form();
        public CrearLibro()
        {
            InitializeComponent();
        }

        private void CrearLibro_Load(object sender, EventArgs e)
        {

        }

        private void txtISBN_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Regex reg = new Regex(@"^\d{10-13}$");
                if (!reg.IsMatch(txtISBN.Text)) throw new FormatException();
            }
            catch (FormatException)
            {

            }
        }

        private void txtTitulo_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Regex reg = new Regex(@"^\w+$");
                if (!reg.IsMatch(txtTitulo.Text)) throw new FormatException();
            }
            catch (FormatException)
            {
                
            }
        }

        private void txtAutor_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Regex reg = new Regex(@"^\w+$");
                if (!reg.IsMatch(txtAutor.Text)) throw new FormatException();
            }
            catch (FormatException)
            {

            }
        }

        private void txtAnio_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Regex reg = new Regex(@"^\d{4}$");
                if (!reg.IsMatch(txtAnio.Text)) throw new FormatException();
            }
            catch (FormatException)
            {

            }
        }

        private void txtCodigoEd_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Regex reg = new Regex(@"^\d{2}$");
                if (!reg.IsMatch(txtCodigoEd.Text)) throw new FormatException();
            }
            catch (FormatException)
            {

            }
        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.EjecutarComandoSinRetornarDatos($"INSERT INTO dbo.Libro(isbn,titulo,autor,año_publicacion,cod_editorial,genero) VALUES ({int.Parse(txtISBN.Text)},'{txtTitulo.Text}','{txtAutor.Text}',{int.Parse(txtAnio.Text)},{int.Parse(txtCodigoEd.Text)},'{comboBox1.SelectedItem}')");
            Close();
        }
    }
}
