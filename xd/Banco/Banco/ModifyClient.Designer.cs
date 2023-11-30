namespace Banco
{
    partial class ModifyClient
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
            components = new System.ComponentModel.Container();
            invisiblePanel = new Panel();
            modify = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            textCC = new TextBox();
            textTlf = new TextBox();
            textEdad = new TextBox();
            textDireccion = new TextBox();
            textNombre = new TextBox();
            textDni = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            bancoBindingSource = new BindingSource(components);
            invisiblePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bancoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // invisiblePanel
            // 
            invisiblePanel.Controls.Add(modify);
            invisiblePanel.Controls.Add(label6);
            invisiblePanel.Controls.Add(label5);
            invisiblePanel.Controls.Add(label4);
            invisiblePanel.Controls.Add(label3);
            invisiblePanel.Controls.Add(label2);
            invisiblePanel.Controls.Add(label7);
            invisiblePanel.Controls.Add(textCC);
            invisiblePanel.Controls.Add(textTlf);
            invisiblePanel.Controls.Add(textEdad);
            invisiblePanel.Controls.Add(textDireccion);
            invisiblePanel.Controls.Add(textNombre);
            invisiblePanel.Controls.Add(textDni);
            invisiblePanel.Location = new Point(4, 90);
            invisiblePanel.Name = "invisiblePanel";
            invisiblePanel.Size = new Size(796, 358);
            invisiblePanel.TabIndex = 0;
            // 
            // modify
            // 
            modify.Location = new Point(533, 146);
            modify.Name = "modify";
            modify.Size = new Size(161, 75);
            modify.TabIndex = 24;
            modify.Text = "Modificar";
            modify.UseVisualStyleBackColor = true;
            modify.Click += modify_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 198);
            label6.Name = "label6";
            label6.Size = new Size(117, 15);
            label6.TabIndex = 23;
            label6.Text = "Nº Cuenta Corriente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(230, 146);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 22;
            label5.Text = "Teléfono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 146);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 21;
            label4.Text = "Edad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 98);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 20;
            label3.Text = "Dirección:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(355, 52);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 19;
            label2.Text = "Nombre:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(59, 52);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 18;
            label7.Text = "DNI:";
            // 
            // textCC
            // 
            textCC.Location = new Point(176, 195);
            textCC.Name = "textCC";
            textCC.Size = new Size(307, 23);
            textCC.TabIndex = 17;
            // 
            // textTlf
            // 
            textTlf.Location = new Point(291, 143);
            textTlf.Name = "textTlf";
            textTlf.Size = new Size(192, 23);
            textTlf.TabIndex = 16;
            // 
            // textEdad
            // 
            textEdad.Location = new Point(95, 143);
            textEdad.Name = "textEdad";
            textEdad.Size = new Size(100, 23);
            textEdad.TabIndex = 15;
            // 
            // textDireccion
            // 
            textDireccion.Location = new Point(95, 95);
            textDireccion.Name = "textDireccion";
            textDireccion.Size = new Size(599, 23);
            textDireccion.TabIndex = 14;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(415, 49);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(279, 23);
            textNombre.TabIndex = 13;
            // 
            // textDni
            // 
            textDni.Location = new Point(95, 49);
            textDni.Name = "textDni";
            textDni.Size = new Size(235, 23);
            textDni.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(218, 15);
            label1.TabIndex = 2;
            label1.Text = "Selecciona el DNI del cliente a modificar";
            // 
            // bancoBindingSource
            // 
            bancoBindingSource.DataSource = typeof(Banco);
            // 
            // ModifyClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(invisiblePanel);
            Name = "ModifyClient";
            Text = "ModifyClient";
            invisiblePanel.ResumeLayout(false);
            invisiblePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bancoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel invisiblePanel;
        private ComboBox comboBox1;
        private BindingSource bancoBindingSource;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private TextBox textCC;
        private TextBox textTlf;
        private TextBox textEdad;
        private TextBox textDireccion;
        private TextBox textNombre;
        private TextBox textDni;
        private Button modify;
    }
}