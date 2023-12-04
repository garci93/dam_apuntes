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
    public partial class AgregarRecurso : Form
    {
        public AgregarRecurso()
        {
            InitializeComponent();
        }

        private void textCodigoRecurso_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(textCodigoRecurso.Text, @"^\d+[A-Z]+$"))
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El código de recurso no es válido");
            }
        }

        private void textNombre_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(textNombre.Text, @"^\w|\s+$"))
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El nombre no es válido");
            }
        }

        private void textDescripcion_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(textDescripcion.Text, @"^\w|\s+$"))
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("La descripción no es válida");
            }
        }

        private void textFechaAdquisicion_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(textFechaAdquisicion.Text, @"^\d{4}$"))
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("La fecha no es válida");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                GestionRecursosDLL.agregarRecurso(textCodigoRecurso.Text, textNombre.Text, textDescripcion.Text, int.Parse(textFechaAdquisicion.Text), comboEstado.SelectedItem.ToString());
                Close();
            }
        }

        private void AgregarRecurso_Load(object sender, EventArgs e)
        {

        }
    }
}
