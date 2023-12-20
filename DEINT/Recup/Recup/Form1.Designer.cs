namespace Recup
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
            btnCrearLibro = new Button();
            btnLeerLibro = new Button();
            btnActualizarLibro = new Button();
            btnEliminarLibro = new Button();
            btnCrearEditorial = new Button();
            btnLeerEditorial = new Button();
            btnActualizarEditorial = new Button();
            btnEliminarEditorial = new Button();
            btnCargar = new Button();
            btnGuardar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCrearLibro
            // 
            btnCrearLibro.Location = new Point(116, 67);
            btnCrearLibro.Name = "btnCrearLibro";
            btnCrearLibro.Size = new Size(124, 23);
            btnCrearLibro.TabIndex = 0;
            btnCrearLibro.Text = "Crear Libro";
            btnCrearLibro.UseVisualStyleBackColor = true;
            btnCrearLibro.Click += btnCrearLibro_Click;
            // 
            // btnLeerLibro
            // 
            btnLeerLibro.Location = new Point(255, 67);
            btnLeerLibro.Name = "btnLeerLibro";
            btnLeerLibro.Size = new Size(124, 23);
            btnLeerLibro.TabIndex = 1;
            btnLeerLibro.Text = "Leer Libro";
            btnLeerLibro.UseVisualStyleBackColor = true;
            // 
            // btnActualizarLibro
            // 
            btnActualizarLibro.Location = new Point(391, 67);
            btnActualizarLibro.Name = "btnActualizarLibro";
            btnActualizarLibro.Size = new Size(124, 23);
            btnActualizarLibro.TabIndex = 2;
            btnActualizarLibro.Text = "Actualizar Libro";
            btnActualizarLibro.UseVisualStyleBackColor = true;
            btnActualizarLibro.Click += btnActualizarLibro_Click;
            // 
            // btnEliminarLibro
            // 
            btnEliminarLibro.Location = new Point(525, 67);
            btnEliminarLibro.Name = "btnEliminarLibro";
            btnEliminarLibro.Size = new Size(124, 23);
            btnEliminarLibro.TabIndex = 3;
            btnEliminarLibro.Text = "Eliminar Libro";
            btnEliminarLibro.UseVisualStyleBackColor = true;
            btnEliminarLibro.Click += btnEliminarLibro_Click;
            // 
            // btnCrearEditorial
            // 
            btnCrearEditorial.Location = new Point(116, 137);
            btnCrearEditorial.Name = "btnCrearEditorial";
            btnCrearEditorial.Size = new Size(124, 23);
            btnCrearEditorial.TabIndex = 4;
            btnCrearEditorial.Text = "Crear Editorial";
            btnCrearEditorial.UseVisualStyleBackColor = true;
            btnCrearEditorial.Click += btnCrearEditorial_Click;
            // 
            // btnLeerEditorial
            // 
            btnLeerEditorial.Location = new Point(255, 137);
            btnLeerEditorial.Name = "btnLeerEditorial";
            btnLeerEditorial.Size = new Size(124, 23);
            btnLeerEditorial.TabIndex = 5;
            btnLeerEditorial.Text = "Leer Editorial";
            btnLeerEditorial.UseVisualStyleBackColor = true;
            // 
            // btnActualizarEditorial
            // 
            btnActualizarEditorial.Location = new Point(391, 137);
            btnActualizarEditorial.Name = "btnActualizarEditorial";
            btnActualizarEditorial.Size = new Size(124, 23);
            btnActualizarEditorial.TabIndex = 6;
            btnActualizarEditorial.Text = "Actualizar Editorial";
            btnActualizarEditorial.UseVisualStyleBackColor = true;
            // 
            // btnEliminarEditorial
            // 
            btnEliminarEditorial.Location = new Point(525, 137);
            btnEliminarEditorial.Name = "btnEliminarEditorial";
            btnEliminarEditorial.Size = new Size(124, 23);
            btnEliminarEditorial.TabIndex = 7;
            btnEliminarEditorial.Text = "Eliminar Editorial";
            btnEliminarEditorial.UseVisualStyleBackColor = true;
            btnEliminarEditorial.Click += btnEliminarEditorial_Click;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(255, 215);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(124, 23);
            btnCargar.TabIndex = 8;
            btnCargar.Text = "Cargar Datos";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(391, 215);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(124, 23);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar Datos";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 150);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnGuardar);
            Controls.Add(btnCargar);
            Controls.Add(btnEliminarEditorial);
            Controls.Add(btnActualizarEditorial);
            Controls.Add(btnLeerEditorial);
            Controls.Add(btnCrearEditorial);
            Controls.Add(btnEliminarLibro);
            Controls.Add(btnActualizarLibro);
            Controls.Add(btnLeerLibro);
            Controls.Add(btnCrearLibro);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCrearLibro;
        private Button btnLeerLibro;
        private Button btnActualizarLibro;
        private Button btnEliminarLibro;
        private Button btnCrearEditorial;
        private Button btnLeerEditorial;
        private Button btnActualizarEditorial;
        private Button btnEliminarEditorial;
        private Button btnCargar;
        private Button btnGuardar;
        private DataGridView dataGridView1;
    }
}
