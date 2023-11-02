namespace AdminIES
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ciclos = new System.Windows.Forms.Button();
            this.estudiantes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ciclos
            // 
            this.ciclos.Location = new System.Drawing.Point(96, 128);
            this.ciclos.Name = "ciclos";
            this.ciclos.Size = new System.Drawing.Size(189, 149);
            this.ciclos.TabIndex = 0;
            this.ciclos.Text = "Ciclos";
            this.ciclos.UseVisualStyleBackColor = true;
            // 
            // estudiantes
            // 
            this.estudiantes.Location = new System.Drawing.Point(361, 128);
            this.estudiantes.Name = "estudiantes";
            this.estudiantes.Size = new System.Drawing.Size(189, 149);
            this.estudiantes.TabIndex = 1;
            this.estudiantes.Text = "Estudiantes";
            this.estudiantes.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.estudiantes);
            this.Controls.Add(this.ciclos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ciclos;
        private System.Windows.Forms.Button estudiantes;
    }
}

