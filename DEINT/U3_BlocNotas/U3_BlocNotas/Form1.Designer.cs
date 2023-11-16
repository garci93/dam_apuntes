namespace U3_BlocNotas
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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            ediciónToolStripMenuItem = new ToolStripMenuItem();
            cortarToolStripMenuItem = new ToolStripMenuItem();
            copiarToolStripMenuItem = new ToolStripMenuItem();
            pegarToolStripMenuItem = new ToolStripMenuItem();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            fuenteToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripBtnNuevo = new ToolStripButton();
            toolStripBtnAbrir = new ToolStripButton();
            toolStripBtnGuardar = new ToolStripButton();
            toolStripBtnCortar = new ToolStripButton();
            toolStripBtnCopiar = new ToolStripButton();
            toolStripBtnPegar = new ToolStripButton();
            toolStripBtnBuscar = new ToolStripButton();
            toolStripBtnFuente = new ToolStripButton();
            toolStripBtnColor = new ToolStripButton();
            richTextBox1 = new RichTextBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, ediciónToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, abrirToolStripMenuItem, guardarToolStripMenuItem, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(180, 22);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(180, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(180, 22);
            guardarToolStripMenuItem.Text = "Guardar";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(180, 22);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // ediciónToolStripMenuItem
            // 
            ediciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cortarToolStripMenuItem, copiarToolStripMenuItem, pegarToolStripMenuItem, buscarToolStripMenuItem, fuenteToolStripMenuItem, colorToolStripMenuItem });
            ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            ediciónToolStripMenuItem.Size = new Size(58, 20);
            ediciónToolStripMenuItem.Text = "Edición";
            // 
            // cortarToolStripMenuItem
            // 
            cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            cortarToolStripMenuItem.Size = new Size(180, 22);
            cortarToolStripMenuItem.Text = "Cortar";
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.Size = new Size(180, 22);
            copiarToolStripMenuItem.Text = "Copiar";
            // 
            // pegarToolStripMenuItem
            // 
            pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            pegarToolStripMenuItem.Size = new Size(180, 22);
            pegarToolStripMenuItem.Text = "Pegar";
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Size = new Size(180, 22);
            buscarToolStripMenuItem.Text = "Buscar";
            // 
            // fuenteToolStripMenuItem
            // 
            fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            fuenteToolStripMenuItem.Size = new Size(180, 22);
            fuenteToolStripMenuItem.Text = "Fuente";
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(180, 22);
            colorToolStripMenuItem.Text = "Color";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripBtnNuevo, toolStripBtnAbrir, toolStripBtnGuardar, toolStripBtnCortar, toolStripBtnCopiar, toolStripBtnPegar, toolStripBtnBuscar, toolStripBtnFuente, toolStripBtnColor });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnNuevo
            // 
            toolStripBtnNuevo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripBtnNuevo.Image = (Image)resources.GetObject("toolStripBtnNuevo.Image");
            toolStripBtnNuevo.ImageTransparentColor = Color.Magenta;
            toolStripBtnNuevo.Name = "toolStripBtnNuevo";
            toolStripBtnNuevo.Size = new Size(23, 22);
            toolStripBtnNuevo.Text = "toolStripButton1";
            // 
            // toolStripBtnAbrir
            // 
            toolStripBtnAbrir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripBtnAbrir.Image = (Image)resources.GetObject("toolStripBtnAbrir.Image");
            toolStripBtnAbrir.ImageTransparentColor = Color.Magenta;
            toolStripBtnAbrir.Name = "toolStripBtnAbrir";
            toolStripBtnAbrir.Size = new Size(23, 22);
            toolStripBtnAbrir.Text = "toolStripButton2";
            // 
            // toolStripBtnGuardar
            // 
            toolStripBtnGuardar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripBtnGuardar.Image = (Image)resources.GetObject("toolStripBtnGuardar.Image");
            toolStripBtnGuardar.ImageTransparentColor = Color.Magenta;
            toolStripBtnGuardar.Name = "toolStripBtnGuardar";
            toolStripBtnGuardar.Size = new Size(23, 22);
            toolStripBtnGuardar.Text = "toolStripButton3";
            // 
            // toolStripBtnCortar
            // 
            toolStripBtnCortar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripBtnCortar.Image = (Image)resources.GetObject("toolStripBtnCortar.Image");
            toolStripBtnCortar.ImageTransparentColor = Color.Magenta;
            toolStripBtnCortar.Name = "toolStripBtnCortar";
            toolStripBtnCortar.Size = new Size(23, 22);
            toolStripBtnCortar.Text = "toolStripButton4";
            // 
            // toolStripBtnCopiar
            // 
            toolStripBtnCopiar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripBtnCopiar.Image = (Image)resources.GetObject("toolStripBtnCopiar.Image");
            toolStripBtnCopiar.ImageTransparentColor = Color.Magenta;
            toolStripBtnCopiar.Name = "toolStripBtnCopiar";
            toolStripBtnCopiar.Size = new Size(23, 22);
            toolStripBtnCopiar.Text = "toolStripButton5";
            // 
            // toolStripBtnPegar
            // 
            toolStripBtnPegar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripBtnPegar.Image = (Image)resources.GetObject("toolStripBtnPegar.Image");
            toolStripBtnPegar.ImageTransparentColor = Color.Magenta;
            toolStripBtnPegar.Name = "toolStripBtnPegar";
            toolStripBtnPegar.Size = new Size(23, 22);
            toolStripBtnPegar.Text = "toolStripButton6";
            // 
            // toolStripBtnBuscar
            // 
            toolStripBtnBuscar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripBtnBuscar.Image = (Image)resources.GetObject("toolStripBtnBuscar.Image");
            toolStripBtnBuscar.ImageTransparentColor = Color.Magenta;
            toolStripBtnBuscar.Name = "toolStripBtnBuscar";
            toolStripBtnBuscar.Size = new Size(23, 22);
            toolStripBtnBuscar.Text = "toolStripButton7";
            // 
            // toolStripBtnFuente
            // 
            toolStripBtnFuente.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripBtnFuente.Image = (Image)resources.GetObject("toolStripBtnFuente.Image");
            toolStripBtnFuente.ImageTransparentColor = Color.Magenta;
            toolStripBtnFuente.Name = "toolStripBtnFuente";
            toolStripBtnFuente.Size = new Size(23, 22);
            toolStripBtnFuente.Text = "toolStripButton8";
            // 
            // toolStripBtnColor
            // 
            toolStripBtnColor.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripBtnColor.Image = (Image)resources.GetObject("toolStripBtnColor.Image");
            toolStripBtnColor.ImageTransparentColor = Color.Magenta;
            toolStripBtnColor.Name = "toolStripBtnColor";
            toolStripBtnColor.Size = new Size(23, 22);
            toolStripBtnColor.Text = "toolStripButton9";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 52);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 373);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(richTextBox1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private RichTextBox richTextBox1;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem ediciónToolStripMenuItem;
        private ToolStripMenuItem cortarToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem pegarToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripMenuItem fuenteToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripButton toolStripBtnNuevo;
        private ToolStripButton toolStripBtnAbrir;
        private ToolStripButton toolStripBtnGuardar;
        private ToolStripButton toolStripBtnCortar;
        private ToolStripButton toolStripBtnCopiar;
        private ToolStripButton toolStripBtnPegar;
        private ToolStripButton toolStripBtnBuscar;
        private ToolStripButton toolStripBtnFuente;
        private ToolStripButton toolStripBtnColor;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}