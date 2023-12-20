namespace IntentoRepasoSerializer
{
    partial class CrearProyectoForm
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
            buttonCrearProyecto = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // buttonCrearProyecto
            // 
            buttonCrearProyecto.Location = new Point(341, 336);
            buttonCrearProyecto.Name = "buttonCrearProyecto";
            buttonCrearProyecto.Size = new Size(135, 32);
            buttonCrearProyecto.TabIndex = 0;
            buttonCrearProyecto.Text = "Crear Proyecto";
            buttonCrearProyecto.UseVisualStyleBackColor = true;
            buttonCrearProyecto.Click += buttonCrearProyecto_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(355, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(355, 144);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(355, 211);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
            // 
            // CrearProyectoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonCrearProyecto);
            Name = "CrearProyectoForm";
            Text = "CrearProyectoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCrearProyecto;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}