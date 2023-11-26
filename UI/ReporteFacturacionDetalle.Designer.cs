namespace UI
{
    partial class ReporteFacturacionDetalle
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
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(65, 43);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(169, 15);
            label1.TabIndex = 0;
            label1.Text = "Descargar el detalle del reporte";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(65, 86);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(100, 36);
            button1.TabIndex = 1;
            button1.Text = "Descargar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ReporteFacturacionDetalle
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(597, 318);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "ReporteFacturacionDetalle";
            Text = "ReporteFacturacionDetalle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}