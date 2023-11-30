namespace Banco
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
            addClient = new Button();
            modifyClient = new Button();
            deleteClient = new Button();
            viewClient = new Button();
            SuspendLayout();
            // 
            // addClient
            // 
            addClient.Location = new Point(93, 157);
            addClient.Name = "addClient";
            addClient.Size = new Size(103, 88);
            addClient.TabIndex = 0;
            addClient.Text = "Añadir Cliente";
            addClient.UseVisualStyleBackColor = true;
            addClient.Click += addClient_Click;
            // 
            // modifyClient
            // 
            modifyClient.Location = new Point(276, 157);
            modifyClient.Name = "modifyClient";
            modifyClient.Size = new Size(103, 88);
            modifyClient.TabIndex = 1;
            modifyClient.Text = "Modificar Cliente";
            modifyClient.UseVisualStyleBackColor = true;
            modifyClient.Click += modifyClient_Click;
            // 
            // deleteClient
            // 
            deleteClient.Location = new Point(438, 157);
            deleteClient.Name = "deleteClient";
            deleteClient.Size = new Size(103, 88);
            deleteClient.TabIndex = 2;
            deleteClient.Text = "Borrar";
            deleteClient.UseVisualStyleBackColor = true;
            deleteClient.Click += deleteClient_Click;
            // 
            // viewClient
            // 
            viewClient.Location = new Point(598, 157);
            viewClient.Name = "viewClient";
            viewClient.Size = new Size(103, 88);
            viewClient.TabIndex = 3;
            viewClient.Text = "Mostrar";
            viewClient.UseVisualStyleBackColor = true;
            viewClient.Click += viewClient_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(viewClient);
            Controls.Add(deleteClient);
            Controls.Add(modifyClient);
            Controls.Add(addClient);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button addClient;
        private Button modifyClient;
        private Button deleteClient;
        private Button viewClient;
    }
}