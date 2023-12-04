namespace GestionProyectos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCrear = new Button();
            btnAgregar = new Button();
            btnEstado = new Button();
            btnExportar = new Button();
            SuspendLayout();
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(25, 21);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(182, 50);
            btnCrear.TabIndex = 0;
            btnCrear.Text = "Crear Proyecto";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(223, 21);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(182, 50);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar Tareas al Proyecto";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEstado
            // 
            btnEstado.Location = new Point(25, 79);
            btnEstado.Name = "btnEstado";
            btnEstado.Size = new Size(182, 50);
            btnEstado.TabIndex = 2;
            btnEstado.Text = "Visualizar Estado del Proyecto";
            btnEstado.UseVisualStyleBackColor = true;
            btnEstado.Click += btnEstado_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(223, 79);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(182, 50);
            btnExportar.TabIndex = 3;
            btnExportar.Text = "Exportar Proyecto";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 150);
            Controls.Add(btnExportar);
            Controls.Add(btnEstado);
            Controls.Add(btnAgregar);
            Controls.Add(btnCrear);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCrear;
        private Button btnAgregar;
        private Button btnEstado;
        private Button btnExportar;
    }
}
