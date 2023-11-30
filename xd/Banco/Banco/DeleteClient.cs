using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class DeleteClient : Form
    {
        Banco banco;
        List<Cliente> clientListFromXML;
        public DeleteClient()
        {
            InitializeComponent();
            invisiblePanel.Visible = false;
            banco = new Banco();
            clientListFromXML = banco.DeserializeAndGetClientesXML();
            List<string> dnis = new List<string>();

            foreach (var cliente in clientListFromXML)
            {
                dnis.Add(cliente.DNI);
            }

            comboBox1.DataSource = dnis;
            textDni.ReadOnly = true;
            textNombre.ReadOnly = true;
            textDireccion.ReadOnly = true;
            textEdad.ReadOnly = true;
            textTlf.ReadOnly = true;
            textCC.ReadOnly = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            invisiblePanel.Visible = true;
            var dniCombo = comboBox1.SelectedItem.ToString();
            textDni.Text = dniCombo;

            foreach (var cliente in clientListFromXML)
            {
                if (cliente.DNI == dniCombo)
                {
                    textNombre.Text = cliente.Nombre;
                    textDireccion.Text = cliente.Direccion;
                    textEdad.Text = $"{cliente.Edad}";
                    textTlf.Text = $"{cliente.Telefono}";
                    textCC.Text = $"{cliente.NCuentaCorriente}";
                }
            }
        }

        private void modify_Click(object sender, EventArgs e)
        {
            banco.removeClient(comboBox1.SelectedIndex);
        }
    }
}
