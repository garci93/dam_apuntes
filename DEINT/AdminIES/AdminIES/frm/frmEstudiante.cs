using AdminIES.DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminIES.frm
{
    public partial class frmEstudiante : Form
    {
        EstudianteDLL estudiantedll;
        public frmEstudiante()
        {
            estudiantedll = new EstudianteDLL();
            InitializeComponent();
            estudiantedll.MostrarEstudiantes();
            dgEstudiante.DataSource = estudiantedll.MostrarEstudiantes().Tables[0];
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EstudianteDLL cicloDLL = new EstudianteDLL();
            if (!textNombre.Text.Equals("")) cicloDLL.Agregar(textNombre.Text, textApellido1.Text, textApellido2.Text, textCorreo.Text, comboBoxCiclo.SelectedText);
            estudiantedll.MostrarEstudiantes();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            EstudianteDLL estudianteDLL = new EstudianteDLL();
            estudianteDLL.Modificar(textClave.Text, textNombre.Text, textApellido1.Text, textApellido2.Text, textCorreo.Text, comboBoxCiclo.SelectedText);
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
    }
}
