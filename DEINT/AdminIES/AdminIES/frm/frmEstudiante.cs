using AdminIES.DLL;
using AdminIES.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminIES.frm
{
    public partial class frmEstudiante : Form
    {
        EstudianteDLL estudiantedll;
        private byte[] imagenByte;

        public frmEstudiante()
        {
            estudiantedll = new EstudianteDLL();
            InitializeComponent();
            estudiantedll.MostrarEstudiantes();
            dgEstudiante.DataSource = estudiantedll.MostrarEstudiantes().Tables[0];
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EstudianteDLL estudianteDLL = new EstudianteDLL();
            if (!textNombre.Text.Equals("")) estudianteDLL.Agregar(textNombre.Text, textApellido1.Text, textApellido2.Text, textCorreo.Text, comboBoxCiclo.SelectedText,pbEstudiante.Image);
            estudiantedll.MostrarEstudiantes();
            dgEstudiante.DataSource = estudiantedll.MostrarEstudiantes().Tables[0]; 
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            EstudianteDLL estudianteDLL = new EstudianteDLL();
            estudianteDLL.Modificar(textClave.Text, textNombre.Text, textApellido1.Text, textApellido2.Text, textCorreo.Text, comboBoxCiclo.SelectedText, pbEstudiante.Image);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            EstudianteDLL estudianteDLL = new EstudianteDLL();
            estudianteDLL.Borrar(textClave.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void frmEstudiante_Load_1(object sender, EventArgs e)
        {

        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorImagen = new OpenFileDialog();
            selectorImagen.Title = "Seleccionar imagen";

            if (selectorImagen.ShowDialog() == DialogResult.OK)
            {
                pbEstudiante.Image = Image.FromStream(selectorImagen.OpenFile());
                MemoryStream memoryStream = new MemoryStream();
                pbEstudiante.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                imagenByte = memoryStream.ToArray();
            }
        }
    }
}
