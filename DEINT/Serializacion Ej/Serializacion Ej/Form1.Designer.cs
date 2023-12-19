namespace Serializacion_Ej
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
            btnAnadir = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnMostrar = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtCC = new TextBox();
            txtTelefono = new TextBox();
            txtEdad = new TextBox();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            txtDNI = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAnadir
            // 
            btnAnadir.Location = new Point(77, 249);
            btnAnadir.Name = "btnAnadir";
            btnAnadir.Size = new Size(103, 34);
            btnAnadir.TabIndex = 0;
            btnAnadir.Text = "Añadir cliente";
            btnAnadir.UseVisualStyleBackColor = true;
            btnAnadir.Click += btnAnadir_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(208, 249);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(111, 34);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar cliente";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(352, 249);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(103, 34);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar cliente";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(483, 249);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(97, 34);
            btnMostrar.TabIndex = 3;
            btnMostrar.Text = "Mostrar cliente";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(95, 193);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 24;
            label6.Text = "Nº de cuenta";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(119, 164);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 23;
            label5.Text = "Teléfono";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 135);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 22;
            label4.Text = "Edad";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 106);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 21;
            label3.Text = "Dirección";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 77);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 20;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 48);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 19;
            label1.Text = "DNI";
            label1.Click += label1_Click;
            // 
            // txtCC
            // 
            txtCC.Location = new Point(211, 190);
            txtCC.Name = "txtCC";
            txtCC.Size = new Size(369, 23);
            txtCC.TabIndex = 18;
            txtCC.TextChanged += textBox6_TextChanged;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(211, 161);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(369, 23);
            txtTelefono.TabIndex = 17;
            txtTelefono.TextChanged += textBox5_TextChanged;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(211, 132);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(369, 23);
            txtEdad.TabIndex = 16;
            txtEdad.TextChanged += textBox4_TextChanged;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(211, 103);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(369, 23);
            txtDireccion.TabIndex = 15;
            txtDireccion.TextChanged += textBox3_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(211, 74);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(369, 23);
            txtNombre.TabIndex = 14;
            txtNombre.TextChanged += textBox2_TextChanged;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(211, 45);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(369, 23);
            txtDNI.TabIndex = 13;
            txtDNI.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 311);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(622, 204);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 527);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCC);
            Controls.Add(txtTelefono);
            Controls.Add(txtEdad);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(txtDNI);
            Controls.Add(btnMostrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAnadir);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAnadir;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnMostrar;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private TextBox txtCC;
        private TextBox txtTelefono;
        private TextBox txtEdad;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private TextBox txtDNI;
    }
}