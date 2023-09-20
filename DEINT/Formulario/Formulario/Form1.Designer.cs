namespace Formulario
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            rbtn1 = new RadioButton();
            rbtn2 = new RadioButton();
            rbtn3 = new RadioButton();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 126);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(480, 126);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Salario";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(233, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(528, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // rbtn1
            // 
            rbtn1.AutoSize = true;
            rbtn1.Location = new Point(193, 250);
            rbtn1.Name = "rbtn1";
            rbtn1.Size = new Size(66, 19);
            rbtn1.TabIndex = 4;
            rbtn1.TabStop = true;
            rbtn1.Text = "Gerente";
            rbtn1.UseVisualStyleBackColor = true;
            rbtn1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbtn2
            // 
            rbtn2.AutoSize = true;
            rbtn2.Location = new Point(369, 250);
            rbtn2.Name = "rbtn2";
            rbtn2.Size = new Size(86, 19);
            rbtn2.TabIndex = 5;
            rbtn2.TabStop = true;
            rbtn2.Text = "SubGerente";
            rbtn2.UseVisualStyleBackColor = true;
            // 
            // rbtn3
            // 
            rbtn3.AutoSize = true;
            rbtn3.Location = new Point(552, 250);
            rbtn3.Name = "rbtn3";
            rbtn3.Size = new Size(76, 19);
            rbtn3.TabIndex = 6;
            rbtn3.TabStop = true;
            rbtn3.Text = "Secretaria";
            rbtn3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(379, 366);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(345, 37);
            label3.Name = "label3";
            label3.Size = new Size(135, 32);
            label3.TabIndex = 8;
            label3.Text = "Problema 1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(rbtn3);
            Controls.Add(rbtn2);
            Controls.Add(rbtn1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private RadioButton rbtn1;
        private RadioButton rbtn2;
        private RadioButton rbtn3;
        private Button button1;
        private Label label3;
    }
}