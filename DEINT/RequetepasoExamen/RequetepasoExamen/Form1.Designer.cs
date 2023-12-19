namespace RequetepasoExamen
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
            this.btnSerXml = new System.Windows.Forms.Button();
            this.btnSerJSON = new System.Windows.Forms.Button();
            this.btnDeserXml = new System.Windows.Forms.Button();
            this.btnDeserJSON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSerXml
            // 
            this.btnSerXml.Location = new System.Drawing.Point(227, 265);
            this.btnSerXml.Name = "btnSerXml";
            this.btnSerXml.Size = new System.Drawing.Size(104, 23);
            this.btnSerXml.TabIndex = 0;
            this.btnSerXml.Text = "Serializar XML";
            this.btnSerXml.UseVisualStyleBackColor = true;
            this.btnSerXml.Click += new System.EventHandler(this.btnSerXml_Click);
            // 
            // btnSerJSON
            // 
            this.btnSerJSON.Location = new System.Drawing.Point(447, 265);
            this.btnSerJSON.Name = "btnSerJSON";
            this.btnSerJSON.Size = new System.Drawing.Size(104, 23);
            this.btnSerJSON.TabIndex = 1;
            this.btnSerJSON.Text = "Serializar JSON";
            this.btnSerJSON.UseVisualStyleBackColor = true;
            this.btnSerJSON.Click += new System.EventHandler(this.btnSerJSON_Click);
            // 
            // btnDeserXml
            // 
            this.btnDeserXml.Location = new System.Drawing.Point(227, 359);
            this.btnDeserXml.Name = "btnDeserXml";
            this.btnDeserXml.Size = new System.Drawing.Size(104, 23);
            this.btnDeserXml.TabIndex = 2;
            this.btnDeserXml.Text = "Deserializar XML";
            this.btnDeserXml.UseVisualStyleBackColor = true;
            this.btnDeserXml.Click += new System.EventHandler(this.btnDeserXml_Click);
            // 
            // btnDeserJSON
            // 
            this.btnDeserJSON.Location = new System.Drawing.Point(447, 359);
            this.btnDeserJSON.Name = "btnDeserJSON";
            this.btnDeserJSON.Size = new System.Drawing.Size(104, 23);
            this.btnDeserJSON.TabIndex = 3;
            this.btnDeserJSON.Text = "Deserializar JSON";
            this.btnDeserJSON.UseVisualStyleBackColor = true;
            this.btnDeserJSON.Click += new System.EventHandler(this.btnDeserJSON_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeserJSON);
            this.Controls.Add(this.btnDeserXml);
            this.Controls.Add(this.btnSerJSON);
            this.Controls.Add(this.btnSerXml);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSerXml;
        private System.Windows.Forms.Button btnSerJSON;
        private System.Windows.Forms.Button btnDeserXml;
        private System.Windows.Forms.Button btnDeserJSON;
    }
}

