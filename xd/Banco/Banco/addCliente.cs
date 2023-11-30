using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Banco
{
    public partial class addCliente : Form
    {
        Banco banco = new Banco();
        public addCliente()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string dniCli = textDni.Text;
            string nombre = textNombre.Text;
            string direccion = textDireccion.Text;
            int edad = int.Parse(textEdad.Text);
            int tlf = int.Parse(textTlf.Text);
            int nCC = int.Parse((textCC.Text));

            Cliente cliente = new Cliente(dniCli, nombre, direccion, edad, tlf, nCC);
            banco.addClienteXML(cliente);
        }

        private void textDni_Validating(object sender, CancelEventArgs e)
        {
            string dniPattern = @"^\d{8}$";

            if (!Regex.IsMatch(textDni.Text, dniPattern))
            {
                MessageBox.Show("Por favor, ingrese un DNI válido (8 dígitos numéricos).", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void textNombre_Validating(object sender, CancelEventArgs e)
        {
            if (textNombre.Text == "")
            {
                MessageBox.Show("Por favor, ingrese un Nombre.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void textDireccion_Validating(object sender, CancelEventArgs e)
        {
            if (textNombre.Text == "")
            {
                MessageBox.Show("Por favor, ingrese una Dirección.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void textEdad_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(textEdad.Text, out _))
            {
                MessageBox.Show("Por favor, ingrese una Edad valida.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void textTlf_Validating(object sender, CancelEventArgs e)
        {
            string tlfPattern = @"^\d{9}$";

            if (!Regex.IsMatch(textTlf.Text, tlfPattern))
            {
                MessageBox.Show("Por favor, ingrese un DNI válido (8 dígitos numéricos).", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void textCC_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(textCC.Text, out _))
            {
                MessageBox.Show("Por favor, ingrese una Cuenta Corriente valida.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void btnJson_Click(object sender, EventArgs e)
        {
            string dniCli = textDni.Text;
            string nombre = textNombre.Text;
            string direccion = textDireccion.Text;
            int edad = int.Parse(textEdad.Text);
            int tlf = int.Parse(textTlf.Text);
            int nCC = int.Parse((textCC.Text));

            Cliente cliente = new Cliente(dniCli, nombre, direccion, edad, tlf, nCC);
            banco.addClienteJSON(cliente);
        }
    }
}
