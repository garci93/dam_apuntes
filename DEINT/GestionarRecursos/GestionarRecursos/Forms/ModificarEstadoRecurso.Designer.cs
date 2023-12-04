namespace GestionarRecursos.Forms
{
    partial class ModificarEstadoRecurso
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
            comboEstado = new ComboBox();
            btnModificar = new Button();
            label1 = new Label();
            textCodigo = new TextBox();
            SuspendLayout();
            // 
            // comboEstado
            // 
            comboEstado.FormattingEnabled = true;
            comboEstado.Items.AddRange(new object[] { "Disponible", "En uso", "Mantenimiento" });
            comboEstado.Location = new Point(44, 46);
            comboEstado.Name = "comboEstado";
            comboEstado.Size = new Size(121, 23);
            comboEstado.TabIndex = 0;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(62, 75);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 19);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 2;
            label1.Text = "Código";
            // 
            // textCodigo
            // 
            textCodigo.Location = new Point(83, 16);
            textCodigo.Name = "textCodigo";
            textCodigo.Size = new Size(100, 23);
            textCodigo.TabIndex = 3;
            textCodigo.TextChanged += textCodigo_TextChanged;
            textCodigo.Validating += textCodigo_Validating;
            // 
            // ModificarEstadoRecurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(204, 116);
            Controls.Add(textCodigo);
            Controls.Add(label1);
            Controls.Add(btnModificar);
            Controls.Add(comboEstado);
            Name = "ModificarEstadoRecurso";
            Text = "Modificar estado recurso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboEstado;
        private Button btnModificar;
        private Label label1;
        private TextBox textCodigo;
    }
}