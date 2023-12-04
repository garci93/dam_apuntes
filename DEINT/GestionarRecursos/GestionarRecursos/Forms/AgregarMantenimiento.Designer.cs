namespace GestionarRecursos.Forms
{
    partial class AgregarMantenimiento
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textCodigo = new TextBox();
            textCodigoMantenimiento = new TextBox();
            textNombre = new TextBox();
            textFechaInicio = new TextBox();
            textFechaFin = new TextBox();
            textDescripcion = new TextBox();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 35);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 85);
            label2.Name = "label2";
            label2.Size = new Size(150, 15);
            label2.TabIndex = 1;
            label2.Text = "Código del mantenimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 130);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 184);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 3;
            label4.Text = "Fecha de inicio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(99, 240);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 4;
            label5.Text = "Fecha de fin";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(101, 284);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 5;
            label6.Text = "Descripción";
            // 
            // textCodigo
            // 
            textCodigo.Location = new Point(186, 27);
            textCodigo.Name = "textCodigo";
            textCodigo.Size = new Size(100, 23);
            textCodigo.TabIndex = 6;
            // 
            // textCodigoMantenimiento
            // 
            textCodigoMantenimiento.Location = new Point(186, 77);
            textCodigoMantenimiento.Name = "textCodigoMantenimiento";
            textCodigoMantenimiento.Size = new Size(100, 23);
            textCodigoMantenimiento.TabIndex = 7;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(186, 127);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(100, 23);
            textNombre.TabIndex = 8;
            // 
            // textFechaInicio
            // 
            textFechaInicio.Location = new Point(186, 184);
            textFechaInicio.Name = "textFechaInicio";
            textFechaInicio.Size = new Size(100, 23);
            textFechaInicio.TabIndex = 9;
            // 
            // textFechaFin
            // 
            textFechaFin.Location = new Point(186, 232);
            textFechaFin.Name = "textFechaFin";
            textFechaFin.Size = new Size(100, 23);
            textFechaFin.TabIndex = 10;
            // 
            // textDescripcion
            // 
            textDescripcion.Location = new Point(186, 281);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(100, 23);
            textDescripcion.TabIndex = 11;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(95, 323);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // AgregarMantenimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 378);
            Controls.Add(btnAgregar);
            Controls.Add(textDescripcion);
            Controls.Add(textFechaFin);
            Controls.Add(textFechaInicio);
            Controls.Add(textNombre);
            Controls.Add(textCodigoMantenimiento);
            Controls.Add(textCodigo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarMantenimiento";
            Text = "AgregarMantenimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textCodigo;
        private TextBox textCodigoMantenimiento;
        private TextBox textNombre;
        private TextBox textFechaInicio;
        private TextBox textFechaFin;
        private TextBox textDescripcion;
        private Button btnAgregar;
    }
}