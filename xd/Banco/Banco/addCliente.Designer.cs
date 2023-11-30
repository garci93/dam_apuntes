namespace Banco
{
    partial class addCliente
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
            textDni = new TextBox();
            textNombre = new TextBox();
            textDireccion = new TextBox();
            textEdad = new TextBox();
            textTlf = new TextBox();
            textCC = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            addXml = new Button();
            btnJson = new Button();
            SuspendLayout();
            // 
            // textDni
            // 
            textDni.Location = new Point(111, 119);
            textDni.Name = "textDni";
            textDni.Size = new Size(235, 23);
            textDni.TabIndex = 0;
            textDni.Validating += textDni_Validating;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(431, 119);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(279, 23);
            textNombre.TabIndex = 1;
            textNombre.Validating += textNombre_Validating;
            // 
            // textDireccion
            // 
            textDireccion.Location = new Point(111, 165);
            textDireccion.Name = "textDireccion";
            textDireccion.Size = new Size(599, 23);
            textDireccion.TabIndex = 2;
            textDireccion.Validating += textDireccion_Validating;
            // 
            // textEdad
            // 
            textEdad.Location = new Point(111, 213);
            textEdad.Name = "textEdad";
            textEdad.Size = new Size(100, 23);
            textEdad.TabIndex = 3;
            textEdad.Validating += textEdad_Validating;
            // 
            // textTlf
            // 
            textTlf.Location = new Point(307, 213);
            textTlf.Name = "textTlf";
            textTlf.Size = new Size(192, 23);
            textTlf.TabIndex = 4;
            textTlf.Validating += textTlf_Validating;
            // 
            // textCC
            // 
            textCC.Location = new Point(192, 265);
            textCC.Name = "textCC";
            textCC.Size = new Size(307, 23);
            textCC.TabIndex = 5;
            textCC.Validating += textCC_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 122);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 6;
            label1.Text = "DNI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(371, 122);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 7;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 168);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 8;
            label3.Text = "Dirección:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 216);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 9;
            label4.Text = "Edad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(246, 216);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 10;
            label5.Text = "Teléfono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 268);
            label6.Name = "label6";
            label6.Size = new Size(117, 15);
            label6.TabIndex = 11;
            label6.Text = "Nº Cuenta Corriente:";
            // 
            // addXml
            // 
            addXml.Location = new Point(549, 213);
            addXml.Name = "addXml";
            addXml.Size = new Size(161, 75);
            addXml.TabIndex = 12;
            addXml.Text = "Añadir como XML";
            addXml.UseVisualStyleBackColor = true;
            addXml.Click += add_Click;
            // 
            // btnJson
            // 
            btnJson.Location = new Point(549, 320);
            btnJson.Name = "btnJson";
            btnJson.Size = new Size(161, 75);
            btnJson.TabIndex = 13;
            btnJson.Text = "Añadir como JSON";
            btnJson.UseVisualStyleBackColor = true;
            btnJson.Click += btnJson_Click;
            // 
            // addCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnJson);
            Controls.Add(addXml);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textCC);
            Controls.Add(textTlf);
            Controls.Add(textEdad);
            Controls.Add(textDireccion);
            Controls.Add(textNombre);
            Controls.Add(textDni);
            Name = "addCliente";
            Text = "addCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textDni;
        private TextBox textNombre;
        private TextBox textDireccion;
        private TextBox textEdad;
        private TextBox textTlf;
        private TextBox textCC;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button addXml;
        private Button btnJson;
    }
}