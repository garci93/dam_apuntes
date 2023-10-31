namespace U3_E2_Formularios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label9 = new Label();
            panel2 = new Panel();
            textBox5 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            listBox1 = new ListBox();
            label6 = new Label();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 180);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Validating += textBox1_Validating;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(174, 180);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.Validating += textBox2_Validating;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(37, 226);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.Validating += textBox3_Validating;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(174, 226);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += textBox4_TextChanged;
            textBox4.Validating += textBox4_Validating;
            // 
            // button1
            // 
            button1.Location = new Point(37, 270);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(118, 270);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(199, 270);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 162);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 7;
            label1.Text = "NIF";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 162);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 8;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 208);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 9;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(174, 208);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 10;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 16);
            label5.Name = "label5";
            label5.Size = new Size(149, 15);
            label5.TabIndex = 11;
            label5.Text = "Información del estudiante";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(110, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Location = new Point(5, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 64);
            panel1.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(310, 25);
            label9.Name = "label9";
            label9.Size = new Size(127, 15);
            label9.TabIndex = 0;
            label9.Text = "Sistema de estudiantes";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(5, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(792, 64);
            panel2.TabIndex = 0;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(425, 21);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(358, 23);
            textBox5.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(377, 29);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 1;
            label8.Text = "Buscar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(78, 24);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 0;
            label7.Text = "Estudiantes";
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(5, 142);
            panel3.Name = "panel3";
            panel3.Size = new Size(322, 300);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(listBox1);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(333, 142);
            panel4.Name = "panel4";
            panel4.Size = new Size(464, 300);
            panel4.TabIndex = 14;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 31);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(458, 259);
            listBox1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(184, 13);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 0;
            label6.Text = "Lista de estudiantes";
            label6.TextAlign = ContentAlignment.TopCenter;
            label6.Click += label6_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label6;
        private Label label9;
        private TextBox textBox5;
        private Label label8;
        private Label label7;
        private ListBox listBox1;
        private OpenFileDialog openFileDialog1;
    }
}