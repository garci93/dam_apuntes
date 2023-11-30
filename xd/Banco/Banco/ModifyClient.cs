using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Banco
{
    public partial class ModifyClient : Form
    {
        Banco banco;
        List<Cliente> clientListFromXML;
        public ModifyClient()
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
            string dniCli = textDni.Text;
            string nombre = textNombre.Text;
            string direccion = textDireccion.Text;
            int edad = int.Parse(textEdad.Text);
            int tlf = int.Parse(textTlf.Text);
            int nCC = int.Parse((textCC.Text));

            Cliente cliente = new Cliente(dniCli, nombre, direccion, edad, tlf, nCC);
            banco.modifyClient(comboBox1.SelectedIndex, cliente);
        }
    }
}
