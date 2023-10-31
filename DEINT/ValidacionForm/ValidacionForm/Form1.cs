namespace ValidacionForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("El carácter introducido no es una cifra");
                e.Handled = true;
            }
        }
        private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void textBox3_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }


        

}
}