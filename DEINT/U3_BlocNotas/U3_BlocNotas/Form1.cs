using System.Windows.Forms;

namespace U3_BlocNotas
{
    public partial class Form1 : Form
    {
        private string rutaArchivo = "";
        public Form1()
        {
            InitializeComponent();
            // Asocia el evento SelectionChanged al RichTextBox
            richTextBox1.SelectionChanged += RichTextBox_SelectionChanged;
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
                        rutaArchivo = saveFileDialog.FileName;

                        System.IO.File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
                        MessageBox.Show("Archivo guardado en: " + rutaArchivo);
                    }
                }
            }
            rutaArchivo = "";
            richTextBox1.Text = string.Empty;
        }

        private void toolStripBtnNuevo_Click(object sender, EventArgs e)
        {
            nuevoToolStripMenuItem_Click(sender, e);
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Archivos de texto enriquecido (*.rtf)|*.rtf";
                openFileDialog.Title = "Abrir archivo";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaArchivo = openFileDialog.FileName;
                    try
                    {
                        string contenidoArchivo = File.ReadAllText(rutaArchivo);
                        richTextBox1.Text = contenidoArchivo;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al leer el archivo: " + ex.Message);
                    }
                }
            }
        }

        private void toolStripBtnAbrir_Click(object sender, EventArgs e)
        {
            abrirToolStripMenuItem_Click(sender, e);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(rutaArchivo))
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    rutaArchivo = saveFileDialog.FileName;
                    saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                    saveFileDialog.Title = "Guardar archivo";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
                        MessageBox.Show("Archivo guardado en: " + rutaArchivo);
                    }
                }
            else
                File.WriteAllText(rutaArchivo, richTextBox1.Text);
        }

        private void toolStripBtnGuardar_Click(object sender, EventArgs e)
        {
            guardarToolStripMenuItem_Click(sender, e);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Eventos
        private void RichTextBox_SelectionChanged(object sender, EventArgs e)
        {
            int line = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart) + 1; // Obtiene la línea actual
            labelLineaActual.Text = "Línea: " + line.ToString(); // Actualiza el Label con el número de línea
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStripBtnCortar_Click(object sender, EventArgs e)
        {
            cortarToolStripMenuItem_Click(sender, e);
        }

        private void toolStripBtnCopiar_Click(object sender, EventArgs e)
        {
            copiarToolStripMenuItem_Click(sender, e);
        }

        private void toolStripBtnPegar_Click(object sender, EventArgs e)
        {
            pegarToolStripMenuItem_Click(sender, e);
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            string textoABuscar = txtBuscar.Text; // Obtiene el texto a buscar desde un TextBox

            if (!string.IsNullOrEmpty(textoABuscar))
            {
                int index = richTextBox1.Find(textoABuscar, richTextBox1.SelectionStart + richTextBox1.SelectionLength, RichTextBoxFinds.None);

                if (index != -1)
                {
                    richTextBox1.Select(index, textoABuscar.Length);
                    richTextBox1.Focus();
                }
                else
                {
                    MessageBox.Show("Texto no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un texto para buscar.");
            }
        }
    }
}