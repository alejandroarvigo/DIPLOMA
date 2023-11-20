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
            btnRegister = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            text1 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            text2 = new System.Windows.Forms.Label();
            text3 = new System.Windows.Forms.Label();
            text4 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new System.Drawing.Point(348, 387);
            btnRegister.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(88, 27);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Registrarse";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(197, 387);
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(454, 80);
            comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(140, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(197, 248);
            textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(239, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(197, 334);
            textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(239, 23);
            textBox2.TabIndex = 5;
            // 
            // text2
            // 
            text2.AutoSize = true;
            text2.Location = new System.Drawing.Point(197, 211);
            text2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            text2.Name = "text2";
            text2.Size = new System.Drawing.Size(0, 15);
            text2.TabIndex = 6;
            // 
            // text3
            // 
            text3.AutoSize = true;
            text3.Location = new System.Drawing.Point(197, 303);
            text3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            text3.Name = "text3";
            text3.Size = new System.Drawing.Size(0, 15);
            text3.TabIndex = 7;
            // 
            // text4
            // 
            text4.AutoSize = true;
            text4.Location = new System.Drawing.Point(450, 57);
            text4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            text4.Name = "text4";
            text4.Size = new System.Drawing.Size(0, 15);
            text4.TabIndex = 8;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(631, 457);
            Controls.Add(text4);
            Controls.Add(text3);
            Controls.Add(text2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(text1);
            Controls.Add(button1);
            Controls.Add(btnRegister);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Login";
            Text = "Form1";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.Label text4;
    }
}

