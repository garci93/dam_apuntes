namespace U3_BlocNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas guardar este archivo?", "Confirmación",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                    saveFileDialog.Title = "Guardar archivo";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string rutaArchivo = saveFileDialog.FileName;


                        MessageBox.Show("Archivo guardado en: " + rutaArchivo);
                    }
                }
            }
            else
            {
                richTextBox1.Text = string.Empty;
            }
        }
    }
}