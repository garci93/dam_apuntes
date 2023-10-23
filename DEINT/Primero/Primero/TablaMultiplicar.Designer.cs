namespace Primero
{
    partial class TablaMultiplicar
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 59);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "NÚMERO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 209);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 2;
            label2.Text = "TABLA DE MULTIPLICAR";
            label2.Click += label2_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(70, 152);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(97, 19);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "ASCENDENTE";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(230, 152);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(103, 19);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "DESCENDENTE";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(137, 57);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 247);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 146);
            textBox1.TabIndex = 8;
            // 
            // TablaMultiplicar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TablaMultiplicar";
            Text = "TablaMultiplicar";
            Load += TablaMultiplicar_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
    }
}