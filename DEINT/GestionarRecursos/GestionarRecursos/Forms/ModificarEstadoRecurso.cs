using GestionarRecursos.DLL;
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

namespace GestionarRecursos.Forms
{
    public partial class ModificarEstadoRecurso : Form
    {
        public ModificarEstadoRecurso()
        {
            InitializeComponent();
        }

        private void textCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCodigo_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(textCodigo.Text, @"^\d+[A-Z]+$"))
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El código de recurso no es válido");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                GestionRecursosDLL.modificarEstadoRecurso(textCodigo.Text, comboEstado.SelectedItem.ToString());
                Close();
            }
        }
    }
}
