namespace Serializacion_Ej
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
            btnAnadir = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnMostrar = new Button();
            SuspendLayout();
            // 
            // btnAnadir
            // 
            btnAnadir.Location = new Point(113, 94);
            btnAnadir.Name = "btnAnadir";
            btnAnadir.Size = new Size(103, 34);
            btnAnadir.TabIndex = 0;
            btnAnadir.Text = "Añadir cliente";
            btnAnadir.UseVisualStyleBackColor = true;
            btnAnadir.Click += btnAnadir_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(301, 94);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(160, 34);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Editar datos de cliente";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(113, 205);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(103, 34);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar cliente";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(301, 205);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(160, 34);
            btnMostrar.TabIndex = 3;
            btnMostrar.Text = "Mostrar datos de cliente";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 329);
            Controls.Add(btnMostrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAnadir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAnadir;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnMostrar;
    }
}