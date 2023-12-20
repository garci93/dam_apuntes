namespace RepasoBBDD
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
            buttonAgregarVehiculos = new Button();
            button2 = new Button();
            buttonVisualizarInventarioVehi = new Button();
            button4 = new Button();
            button5 = new Button();
            buttonPruebaRepaso = new Button();
            SuspendLayout();
            // 
            // buttonAgregarVehiculos
            // 
            buttonAgregarVehiculos.Location = new Point(161, 118);
            buttonAgregarVehiculos.Name = "buttonAgregarVehiculos";
            buttonAgregarVehiculos.Size = new Size(142, 46);
            buttonAgregarVehiculos.TabIndex = 0;
            buttonAgregarVehiculos.Text = "Agregar Vehiculos";
            buttonAgregarVehiculos.UseVisualStyleBackColor = true;
            buttonAgregarVehiculos.Click += buttonAgregarVehiculos_Click;
            // 
            // button2
            // 
            button2.Location = new Point(161, 209);
            button2.Name = "button2";
            button2.Size = new Size(142, 46);
            button2.TabIndex = 1;
            button2.Text = "Modificar Estado Vehiculo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonVisualizarInventarioVehi
            // 
            buttonVisualizarInventarioVehi.Location = new Point(438, 118);
            buttonVisualizarInventarioVehi.Name = "buttonVisualizarInventarioVehi";
            buttonVisualizarInventarioVehi.Size = new Size(142, 46);
            buttonVisualizarInventarioVehi.TabIndex = 2;
            buttonVisualizarInventarioVehi.Text = "Visualizar Inventario Vehiculos";
            buttonVisualizarInventarioVehi.UseVisualStyleBackColor = true;
            buttonVisualizarInventarioVehi.Click += buttonVisualizarInventarioVehi_Click;
            // 
            // button4
            // 
            button4.Location = new Point(438, 209);
            button4.Name = "button4";
            button4.Size = new Size(142, 46);
            button4.TabIndex = 3;
            button4.Text = "Agregar Mantenimiento";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(161, 284);
            button5.Name = "button5";
            button5.Size = new Size(142, 46);
            button5.TabIndex = 4;
            button5.Text = "Visualizar Mantenimiento";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // buttonPruebaRepaso
            // 
            buttonPruebaRepaso.Location = new Point(438, 284);
            buttonPruebaRepaso.Name = "buttonPruebaRepaso";
            buttonPruebaRepaso.Size = new Size(142, 46);
            buttonPruebaRepaso.TabIndex = 5;
            buttonPruebaRepaso.Text = "Prueba Repaso General";
            buttonPruebaRepaso.UseVisualStyleBackColor = true;
            buttonPruebaRepaso.Click += buttonPruebaRepaso_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonPruebaRepaso);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(buttonVisualizarInventarioVehi);
            Controls.Add(button2);
            Controls.Add(buttonAgregarVehiculos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAgregarVehiculos;
        private Button button2;
        private Button buttonVisualizarInventarioVehi;
        private Button button4;
        private Button button5;
        private Button buttonPruebaRepaso;
    }
}
