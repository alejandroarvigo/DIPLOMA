namespace UI
{
    partial class Reportes
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
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            Clientes = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(29, 36);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(105, 28);
            button1.TabIndex = 0;
            button1.Text = "Facturacion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(29, 135);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(105, 28);
            button2.TabIndex = 1;
            button2.Text = "Compras";
            button2.UseVisualStyleBackColor = true;
            // 
            // Clientes
            // 
            Clientes.Location = new System.Drawing.Point(29, 249);
            Clientes.Name = "Clientes";
            Clientes.Size = new System.Drawing.Size(105, 28);
            Clientes.TabIndex = 2;
            Clientes.Text = "Clientes";
            Clientes.UseVisualStyleBackColor = true;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(647, 337);
            Controls.Add(Clientes);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Reportes";
            Text = "Reportes";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Clientes;
    }
}