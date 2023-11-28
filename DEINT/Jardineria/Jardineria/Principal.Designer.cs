namespace Jardineria
{
    partial class Principal
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
            btnAnadirProducto = new Button();
            btnEliminarGama = new Button();
            btnConsultarPedidosEntregados = new Button();
            btnConsultarEmpleadosJefe = new Button();
            btnConsultarClientesNoPagan = new Button();
            btnConsultarPrecioCaroBarato = new Button();
            SuspendLayout();
            // 
            // btnAnadirProducto
            // 
            btnAnadirProducto.Location = new Point(92, 28);
            btnAnadirProducto.Name = "btnAnadirProducto";
            btnAnadirProducto.Size = new Size(112, 47);
            btnAnadirProducto.TabIndex = 0;
            btnAnadirProducto.Text = "Añadir producto";
            btnAnadirProducto.UseVisualStyleBackColor = true;
            btnAnadirProducto.Click += btnAnadirProducto_Click;
            // 
            // btnEliminarGama
            // 
            btnEliminarGama.Location = new Point(69, 81);
            btnEliminarGama.Name = "btnEliminarGama";
            btnEliminarGama.Size = new Size(169, 47);
            btnEliminarGama.TabIndex = 1;
            btnEliminarGama.Text = "Eliminar gama de productos";
            btnEliminarGama.UseVisualStyleBackColor = true;
            btnEliminarGama.Click += btnEliminarGama_Click;
            // 
            // btnConsultarPedidosEntregados
            // 
            btnConsultarPedidosEntregados.Location = new Point(92, 136);
            btnConsultarPedidosEntregados.Name = "btnConsultarPedidosEntregados";
            btnConsultarPedidosEntregados.Size = new Size(113, 47);
            btnConsultarPedidosEntregados.TabIndex = 2;
            btnConsultarPedidosEntregados.Text = "Consultar pedidos entregados";
            btnConsultarPedidosEntregados.UseVisualStyleBackColor = true;
            btnConsultarPedidosEntregados.Click += btnConsultarPedidosEntregados_Click;
            // 
            // btnConsultarEmpleadosJefe
            // 
            btnConsultarEmpleadosJefe.Location = new Point(58, 189);
            btnConsultarEmpleadosJefe.Name = "btnConsultarEmpleadosJefe";
            btnConsultarEmpleadosJefe.Size = new Size(177, 47);
            btnConsultarEmpleadosJefe.TabIndex = 3;
            btnConsultarEmpleadosJefe.Text = "Consultar empleados por jefe";
            btnConsultarEmpleadosJefe.UseVisualStyleBackColor = true;
            btnConsultarEmpleadosJefe.Click += btnConsultarEmpleadosJefe_Click;
            // 
            // btnConsultarClientesNoPagan
            // 
            btnConsultarClientesNoPagan.Location = new Point(48, 242);
            btnConsultarClientesNoPagan.Name = "btnConsultarClientesNoPagan";
            btnConsultarClientesNoPagan.Size = new Size(190, 47);
            btnConsultarClientesNoPagan.TabIndex = 4;
            btnConsultarClientesNoPagan.Text = "Consultar clientes que no pagan";
            btnConsultarClientesNoPagan.UseVisualStyleBackColor = true;
            btnConsultarClientesNoPagan.Click += btnConsultarClientesNoPagan_Click;
            // 
            // btnConsultarPrecioCaroBarato
            // 
            btnConsultarPrecioCaroBarato.Location = new Point(81, 295);
            btnConsultarPrecioCaroBarato.Name = "btnConsultarPrecioCaroBarato";
            btnConsultarPrecioCaroBarato.Size = new Size(133, 47);
            btnConsultarPrecioCaroBarato.TabIndex = 5;
            btnConsultarPrecioCaroBarato.Text = "Consultar precios mínimo y máximo";
            btnConsultarPrecioCaroBarato.UseVisualStyleBackColor = true;
            btnConsultarPrecioCaroBarato.Click += btnConsultarPrecioCaroBarato_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 368);
            Controls.Add(btnConsultarPrecioCaroBarato);
            Controls.Add(btnConsultarClientesNoPagan);
            Controls.Add(btnConsultarEmpleadosJefe);
            Controls.Add(btnConsultarPedidosEntregados);
            Controls.Add(btnEliminarGama);
            Controls.Add(btnAnadirProducto);
            Name = "Principal";
            Text = "Menú principal";
            Load += Principal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAnadirProducto;
        private Button btnEliminarGama;
        private Button btnConsultarPedidosEntregados;
        private Button btnConsultarEmpleadosJefe;
        private Button btnConsultarClientesNoPagan;
        private Button btnConsultarPrecioCaroBarato;
    }
}