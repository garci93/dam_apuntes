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
    public partial class frmCiclo : Form
    {
        CicloDLL ciclodll;
        public frmCiclo()
        {
            ciclodll = new CicloDLL();
            InitializeComponent();
            ciclodll.MostrarCiclos();
            dgCiclo.DataSource = ciclodll.MostrarCiclos().Tables[0];
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CicloDLL cicloDLL = new CicloDLL();
            if (!textCiclo.Text.Equals("")) cicloDLL.Agregar(textCiclo.Text);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CicloDLL cicloDLL = new CicloDLL();
            cicloDLL.Modificar(textID.Text, textCiclo.Text);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            CicloDLL cicloDLL = new CicloDLL();
            cicloDLL.Borrar(textID.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
