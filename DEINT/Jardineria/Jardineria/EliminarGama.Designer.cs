namespace Jardineria
{
    partial class EliminarGama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxGama = new ComboBox();
            label1 = new Label();
            btnEliminarGama = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxGama
            // 
            comboBoxGama.FormattingEnabled = true;
            comboBoxGama.Location = new Point(159, 26);
            comboBoxGama.Name = "comboBoxGama";
            comboBoxGama.Size = new Size(121, 23);
            comboBoxGama.TabIndex = 0;
            comboBoxGama.SelectedIndexChanged += comboBoxGama_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 29);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 1;
            label1.Text = "Gama a eliminar";
            // 
            // btnEliminarGama
            // 
            btnEliminarGama.Location = new Point(177, 66);
            btnEliminarGama.Name = "btnEliminarGama";
            btnEliminarGama.Size = new Size(75, 23);
            btnEliminarGama.TabIndex = 7;
            btnEliminarGama.Text = "Eliminar";
            btnEliminarGama.UseVisualStyleBackColor = true;
            btnEliminarGama.Click += btnEliminarGama_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(394, 279);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // EliminarGama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 398);
            Controls.Add(dataGridView1);
            Controls.Add(btnEliminarGama);
            Controls.Add(label1);
            Controls.Add(comboBoxGama);
            Name = "EliminarGama";
            Text = "Eliminar gama";
            Load += EliminarGama_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnEliminarGama;
        private Label label4;
        private ComboBox comboBoxGama;
        private TextBox textDescripcipn;
        private TextBox textAlt;
        private TextBox textDescripcion;
        private DataGridView dataGridView1;
    }
}