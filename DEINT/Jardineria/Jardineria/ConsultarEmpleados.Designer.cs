namespace Jardineria
{
    partial class ConsultarEmpleados
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
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            btnMostrarEmpleados = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 72);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(487, 366);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 28);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 1;
            label1.Text = "Código de jefe";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(159, 25);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // btnMostrarEmpleados
            // 
            btnMostrarEmpleados.Location = new Point(304, 25);
            btnMostrarEmpleados.Name = "btnMostrarEmpleados";
            btnMostrarEmpleados.Size = new Size(131, 23);
            btnMostrarEmpleados.TabIndex = 3;
            btnMostrarEmpleados.Text = "Mostrar empleados";
            btnMostrarEmpleados.UseVisualStyleBackColor = true;
            btnMostrarEmpleados.Click += btnMostrarEmpleados_Click;
            // 
            // ConsultarEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 450);
            Controls.Add(btnMostrarEmpleados);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "ConsultarEmpleados";
            Text = "ConsultarEmpleados";
            Load += ConsultarEmpleados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Button btnMostrarEmpleados;
    }
}