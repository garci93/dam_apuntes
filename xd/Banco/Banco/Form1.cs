namespace Banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            addCliente addCliente = new addCliente();
            addCliente.Show();
        }

        private void modifyClient_Click(object sender, EventArgs e)
        {
            ModifyClient modifyClient = new ModifyClient();
            modifyClient.Show();
        }

        private void deleteClient_Click(object sender, EventArgs e)
        {
            DeleteClient deleteClient = new DeleteClient();
            deleteClient.Show();
        }

        private void viewClient_Click(object sender, EventArgs e)
        {
            ViewClient viewClient = new ViewClient();
            viewClient.Show();
        }
    }
}