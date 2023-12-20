namespace IntentoRepasoSerializer
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
            buttonCrearProyecto = new Button();
            buttonAgregarTareas = new Button();
            buttonVisualizar = new Button();
            buttonExportar = new Button();
            SuspendLayout();
            // 
            // buttonCrearProyecto
            // 
            buttonCrearProyecto.Location = new Point(196, 122);
            buttonCrearProyecto.Name = "buttonCrearProyecto";
            buttonCrearProyecto.Size = new Size(120, 46);
            buttonCrearProyecto.TabIndex = 0;
            buttonCrearProyecto.Text = "Crear Proyecto";
            buttonCrearProyecto.UseVisualStyleBackColor = true;
            buttonCrearProyecto.Click += buttonCrearProyecto_Click;
            // 
            // buttonAgregarTareas
            // 
            buttonAgregarTareas.Location = new Point(445, 122);
            buttonAgregarTareas.Name = "buttonAgregarTareas";
            buttonAgregarTareas.Size = new Size(120, 46);
            buttonAgregarTareas.TabIndex = 1;
            buttonAgregarTareas.Text = "Agregar Tareas al Proyecto";
            buttonAgregarTareas.UseVisualStyleBackColor = true;
            buttonAgregarTareas.Click += buttonAgregarTareas_Click;
            // 
            // buttonVisualizar
            // 
            buttonVisualizar.Location = new Point(196, 225);
            buttonVisualizar.Name = "buttonVisualizar";
            buttonVisualizar.Size = new Size(156, 46);
            buttonVisualizar.TabIndex = 2;
            buttonVisualizar.Text = "Visualizar informacion del proyecto";
            buttonVisualizar.UseVisualStyleBackColor = true;
            buttonVisualizar.Click += buttonVisualizar_Click;
            // 
            // buttonExportar
            // 
            buttonExportar.Location = new Point(445, 225);
            buttonExportar.Name = "buttonExportar";
            buttonExportar.Size = new Size(120, 46);
            buttonExportar.TabIndex = 3;
            buttonExportar.Text = "Exportar Proyecto";
            buttonExportar.UseVisualStyleBackColor = true;
            buttonExportar.Click += buttonExportar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonExportar);
            Controls.Add(buttonVisualizar);
            Controls.Add(buttonAgregarTareas);
            Controls.Add(buttonCrearProyecto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCrearProyecto;
        private Button buttonAgregarTareas;
        private Button buttonVisualizar;
        private Button buttonExportar;
    }
}
