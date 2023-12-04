namespace GestionProyectos
{
    partial class AgregarTareas
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            textBox4 = new TextBox();
            btnAgregarXML = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 36);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 95);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Descripción";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 157);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha de vencimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 224);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "Estado";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += this.textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(166, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(142, 23);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += this.textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(166, 154);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(142, 23);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += this.textBox3_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Pendiente", "En progreso", "Completada" });
            comboBox1.Location = new Point(166, 221);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 283);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 8;
            label5.Text = "Nombre del proyecto";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(166, 283);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(142, 23);
            textBox4.TabIndex = 9;
            textBox4.TextChanged += this.textBox4_TextChanged;
            // 
            // btnAgregarXML
            // 
            btnAgregarXML.Location = new Point(127, 345);
            btnAgregarXML.Name = "btnAgregarXML";
            btnAgregarXML.Size = new Size(75, 23);
            btnAgregarXML.TabIndex = 10;
            btnAgregarXML.Text = "Agregar";
            btnAgregarXML.UseVisualStyleBackColor = true;
            // 
            // AgregarTareas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 401);
            Controls.Add(btnAgregarXML);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarTareas";
            Text = "Agregar tarea";
            Load += this.AgregarTareas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox textBox4;
        private Button btnAgregarXML;
    }
}