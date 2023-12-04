
namespace GestionarRecursos
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
            btnAgregarRecurso = new Button();
            btnModificarRecurso = new Button();
            btnVisualizarInventarioRecursos = new Button();
            btnAgregarMantenimiento = new Button();
            btnVisualizarMantenimientos = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnAgregarRecurso
            // 
            btnAgregarRecurso.Location = new Point(50, 31);
            btnAgregarRecurso.Name = "btnAgregarRecurso";
            btnAgregarRecurso.Size = new Size(152, 49);
            btnAgregarRecurso.TabIndex = 0;
            btnAgregarRecurso.Text = "Agregar recurso tecnológico";
            btnAgregarRecurso.UseVisualStyleBackColor = true;
            btnAgregarRecurso.Click += btnAgregarRecurso_Click;
            // 
            // btnModificarRecurso
            // 
            btnModificarRecurso.Location = new Point(50, 86);
            btnModificarRecurso.Name = "btnModificarRecurso";
            btnModificarRecurso.Size = new Size(152, 49);
            btnModificarRecurso.TabIndex = 1;
            btnModificarRecurso.Text = "Modificar estado del recurso";
            btnModificarRecurso.UseVisualStyleBackColor = true;
            btnModificarRecurso.Click += btnModificarRecurso_Click;
            // 
            // btnVisualizarInventarioRecursos
            // 
            btnVisualizarInventarioRecursos.Location = new Point(50, 141);
            btnVisualizarInventarioRecursos.Name = "btnVisualizarInventarioRecursos";
            btnVisualizarInventarioRecursos.Size = new Size(152, 49);
            btnVisualizarInventarioRecursos.TabIndex = 2;
            btnVisualizarInventarioRecursos.Text = "Visualizar inventario de recursos";
            btnVisualizarInventarioRecursos.UseVisualStyleBackColor = true;
            btnVisualizarInventarioRecursos.Click += btnVisualizarInventarioRecursos_Click;
            // 
            // btnAgregarMantenimiento
            // 
            btnAgregarMantenimiento.Location = new Point(50, 196);
            btnAgregarMantenimiento.Name = "btnAgregarMantenimiento";
            btnAgregarMantenimiento.Size = new Size(152, 49);
            btnAgregarMantenimiento.TabIndex = 3;
            btnAgregarMantenimiento.Text = "Agregar mantenimiento";
            btnAgregarMantenimiento.UseVisualStyleBackColor = true;
            btnAgregarMantenimiento.Click += btnAgregarMantenimiento_Click;
            // 
            // btnVisualizarMantenimientos
            // 
            btnVisualizarMantenimientos.Location = new Point(50, 251);
            btnVisualizarMantenimientos.Name = "btnVisualizarMantenimientos";
            btnVisualizarMantenimientos.Size = new Size(152, 49);
            btnVisualizarMantenimientos.TabIndex = 4;
            btnVisualizarMantenimientos.Text = "Visualizar mantenimientos";
            btnVisualizarMantenimientos.UseVisualStyleBackColor = true;
            btnVisualizarMantenimientos.Click += btnVisualizarMantenimientos_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(88, 319);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 49);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 403);
            Controls.Add(btnSalir);
            Controls.Add(btnVisualizarMantenimientos);
            Controls.Add(btnAgregarMantenimiento);
            Controls.Add(btnVisualizarInventarioRecursos);
            Controls.Add(btnModificarRecurso);
            Controls.Add(btnAgregarRecurso);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        

        #endregion

        private Button btnAgregarRecurso;
        private Button btnModificarRecurso;
        private Button btnVisualizarInventarioRecursos;
        private Button btnAgregarMantenimiento;
        private Button btnVisualizarMantenimientos;
        private Button btnSalir;
    }
}
