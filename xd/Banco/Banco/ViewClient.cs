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
    public partial class ViewClient : Form
    {
        private DataSet clientDataSet;
        Banco banco;
        List<Cliente> clientListFromXML;
        public ViewClient()
        {
            InitializeComponent();
            banco = new Banco();
            clientListFromXML = banco.DeserializeAndGetClientesXML();
            clientDataSet = new DataSet();
            DataTable tb = new DataTable("tb");

            tb.Columns.Add("DNI");
            tb.Columns.Add("Nombre");
            tb.Columns.Add("Dirección");
            tb.Columns.Add("Edad");
            tb.Columns.Add("Teléfono");
            tb.Columns.Add("Nº Cuenta Corriente");

            foreach (var clients in clientListFromXML)
            {
                tb.Rows.Add(clients.DNI, clients.Nombre, clients.Direccion, clients.Edad, clients.Telefono, clients.NCuentaCorriente);
            }

            clientDataSet.Tables.Add(tb);
            dataGridView1.DataSource = clientDataSet.Tables["tb"];
        }
    }
}
