namespace Jardineria
{
    partial class AnadirProducto
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label1 = new Label();
            btnAnadir = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(492, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 23);
            textBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(144, 97);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(270, 23);
            comboBox1.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(516, 100);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(219, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(174, 153);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(240, 23);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(510, 153);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(225, 23);
            textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(160, 205);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(37, 23);
            textBox6.TabIndex = 6;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(308, 205);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(145, 23);
            textBox7.TabIndex = 7;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(590, 205);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(145, 23);
            textBox8.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 50);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 9;
            label1.Text = "Código";
            label1.Click += label1_Click;
            // 
            // btnAnadir
            // 
            btnAnadir.Location = new Point(378, 263);
            btnAnadir.Name = "btnAnadir";
            btnAnadir.Size = new Size(75, 23);
            btnAnadir.TabIndex = 10;
            btnAnadir.Text = "Añadir";
            btnAnadir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(435, 50);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 11;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 100);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 12;
            label3.Text = "Gama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(435, 100);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 13;
            label4.Text = "Dimensiones";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(100, 156);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 14;
            label5.Text = "Proveedor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(435, 156);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 15;
            label6.Text = "Descripción";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 208);
            label7.Name = "label7";
            label7.Size = new Size(102, 15);
            label7.TabIndex = 16;
            label7.Text = "Cantidad en stock";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(207, 208);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 17;
            label8.Text = "Precio de venta";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(468, 208);
            label9.Name = "label9";
            label9.Size = new Size(116, 15);
            label9.TabIndex = 18;
            label9.Text = "Precio del proveedor";
            // 
            // AnadirProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 329);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAnadir);
            Controls.Add(label1);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "AnadirProducto";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label1;
        private Button btnAnadir;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}