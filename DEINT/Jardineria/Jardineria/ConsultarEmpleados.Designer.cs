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
            label1 = new Label();
            textCodigoJefe = new TextBox();
            btnMostrarEmpleados = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
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
            // textCodigoJefe
            // 
            textCodigoJefe.Location = new Point(159, 25);
            textCodigoJefe.Name = "textCodigoJefe";
            textCodigoJefe.Size = new Size(100, 23);
            textCodigoJefe.TabIndex = 2;
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
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 73);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(487, 349);
            listBox1.TabIndex = 4;
            // 
            // ConsultarEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 450);
            Controls.Add(listBox1);
            Controls.Add(btnMostrarEmpleados);
            Controls.Add(textCodigoJefe);
            Controls.Add(label1);
            Name = "ConsultarEmpleados";
            Text = "Consultar empleados por jefe";
            Load += ConsultarEmpleados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textCodigoJefe;
        private Button btnMostrarEmpleados;
        private ListBox listBox1;
    }
}