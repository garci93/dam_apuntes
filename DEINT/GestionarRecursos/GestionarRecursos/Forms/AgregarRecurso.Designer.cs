namespace GestionarRecursos.Forms
{
    partial class AgregarRecurso
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textCodigoRecurso = new TextBox();
            textNombre = new TextBox();
            textDescripcion = new TextBox();
            textFechaAdquisicion = new TextBox();
            comboEstado = new ComboBox();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 39);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 1;
            label2.Text = "Código del recurso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 65);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 97);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 3;
            label4.Text = "Descripción";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 126);
            label5.Name = "label5";
            label5.Size = new Size(118, 15);
            label5.TabIndex = 4;
            label5.Text = "Fecha de adquisición";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(99, 155);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 5;
            label6.Text = "Estado";
            // 
            // textCodigoRecurso
            // 
            textCodigoRecurso.Location = new Point(166, 36);
            textCodigoRecurso.Name = "textCodigoRecurso";
            textCodigoRecurso.Size = new Size(100, 23);
            textCodigoRecurso.TabIndex = 7;
            textCodigoRecurso.Validating += textCodigoRecurso_Validating;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(166, 65);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(100, 23);
            textNombre.TabIndex = 8;
            textNombre.Validating += textNombre_Validating;
            // 
            // textDescripcion
            // 
            textDescripcion.Location = new Point(166, 94);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(100, 23);
            textDescripcion.TabIndex = 9;
            textDescripcion.Validating += textDescripcion_Validating;
            // 
            // textFechaAdquisicion
            // 
            textFechaAdquisicion.Location = new Point(166, 123);
            textFechaAdquisicion.Name = "textFechaAdquisicion";
            textFechaAdquisicion.Size = new Size(100, 23);
            textFechaAdquisicion.TabIndex = 10;
            textFechaAdquisicion.Validating += textFechaAdquisicion_Validating;
            // 
            // comboEstado
            // 
            comboEstado.FormattingEnabled = true;
            comboEstado.Items.AddRange(new object[] { "Disponible", "En uso", "En mantenimiento" });
            comboEstado.Location = new Point(166, 152);
            comboEstado.Name = "comboEstado";
            comboEstado.Size = new Size(121, 23);
            comboEstado.TabIndex = 11;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(116, 197);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // AgregarRecurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 258);
            Controls.Add(btnAgregar);
            Controls.Add(comboEstado);
            Controls.Add(textFechaAdquisicion);
            Controls.Add(textDescripcion);
            Controls.Add(textNombre);
            Controls.Add(textCodigoRecurso);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "AgregarRecurso";
            Text = "AgregarRecurso";
            Load += AgregarRecurso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textCodigoRecurso;
        private TextBox textNombre;
        private TextBox textDescripcion;
        private TextBox textFechaAdquisicion;
        private ComboBox comboEstado;
        private Button btnAgregar;
    }
}