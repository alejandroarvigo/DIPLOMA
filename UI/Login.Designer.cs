namespace UI
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new System.Windows.Forms.Button();
            text1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            text2 = new System.Windows.Forms.Label();
            text3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(270, 293);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(88, 27);
            button1.TabIndex = 1;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // text1
            // 
            text1.AutoSize = true;
            text1.Location = new System.Drawing.Point(197, 57);
            text1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            text1.Name = "text1";
            text1.Size = new System.Drawing.Size(0, 15);
            text1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(197, 122);
            textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(239, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(197, 219);
            textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(239, 23);
            textBox2.TabIndex = 5;
            // 
            // text2
            // 
            text2.AutoSize = true;
            text2.Location = new System.Drawing.Point(197, 68);
            text2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            text2.Name = "text2";
            text2.Size = new System.Drawing.Size(0, 15);
            text2.TabIndex = 6;
            // 
            // text3
            // 
            text3.AutoSize = true;
            text3.Location = new System.Drawing.Point(197, 174);
            text3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            text3.Name = "text3";
            text3.Size = new System.Drawing.Size(0, 15);
            text3.TabIndex = 7;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(599, 410);
            Controls.Add(text3);
            Controls.Add(text2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(text1);
            Controls.Add(button1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Login";
            Text = "Form1";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Label text3;
    }
}

