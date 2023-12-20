namespace RepasoBBDD
{
    partial class PruebaForm
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
            buttonAgregarPrueba = new Button();
            textBoxCodigo = new TextBox();
            textBoxPrueba = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            buttonModificar = new Button();
            buttonBorrarPrueba = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonAgregarPrueba
            // 
            buttonAgregarPrueba.Location = new Point(447, 49);
            buttonAgregarPrueba.Name = "buttonAgregarPrueba";
            buttonAgregarPrueba.Size = new Size(103, 23);
            buttonAgregarPrueba.TabIndex = 0;
            buttonAgregarPrueba.Text = "AgregarPrueba";
            buttonAgregarPrueba.UseVisualStyleBackColor = true;
            buttonAgregarPrueba.Click += buttonAgregarPrueba_Click;
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(66, 49);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(100, 23);
            textBoxCodigo.TabIndex = 1;
            // 
            // textBoxPrueba
            // 
            textBoxPrueba.Location = new Point(228, 49);
            textBoxPrueba.Name = "textBoxPrueba";
            textBoxPrueba.Size = new Size(100, 23);
            textBoxPrueba.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 21);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 3;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 21);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 4;
            label2.Text = "Prueba";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(347, 181);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(447, 114);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(103, 23);
            buttonModificar.TabIndex = 6;
            buttonModificar.Text = "ModificarPrueba";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonBorrarPrueba
            // 
            buttonBorrarPrueba.Location = new Point(447, 184);
            buttonBorrarPrueba.Name = "buttonBorrarPrueba";
            buttonBorrarPrueba.Size = new Size(103, 23);
            buttonBorrarPrueba.TabIndex = 7;
            buttonBorrarPrueba.Text = "BorrarPrueba";
            buttonBorrarPrueba.UseVisualStyleBackColor = true;
            buttonBorrarPrueba.Click += buttonBorrarPrueba_Click;
            // 
            // PruebaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBorrarPrueba);
            Controls.Add(buttonModificar);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPrueba);
            Controls.Add(textBoxCodigo);
            Controls.Add(buttonAgregarPrueba);
            Name = "PruebaForm";
            Text = "PruebaForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAgregarPrueba;
        private TextBox textBoxCodigo;
        private TextBox textBoxPrueba;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Button buttonModificar;
        private Button buttonBorrarPrueba;
    }
}