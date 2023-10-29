namespace UI
{
    partial class ReservaDetalle
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
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            endTimeLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            costoLbl = new System.Windows.Forms.Label();
            CostoMdfLbl = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            ClienteLbl = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(60, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Habitacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(60, 123);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Detalle";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(60, 62);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Numero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(60, 157);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(37, 15);
            label4.TabIndex = 3;
            label4.Text = "Detail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(450, 30);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(73, 15);
            label5.TabIndex = 4;
            label5.Text = "Fecha Desde";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(452, 123);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(71, 15);
            label6.TabIndex = 5;
            label6.Text = "Fecha Hasta";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(60, 339);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Reservar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Location = new System.Drawing.Point(452, 157);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(71, 15);
            endTimeLabel.TabIndex = 7;
            endTimeLabel.Text = "Fecha Hasta";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new System.Drawing.Point(450, 62);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(71, 15);
            startTimeLabel.TabIndex = 8;
            startTimeLabel.Text = "Fecha Hasta";
            // 
            // costoLbl
            // 
            costoLbl.AutoSize = true;
            costoLbl.Location = new System.Drawing.Point(60, 238);
            costoLbl.Name = "costoLbl";
            costoLbl.Size = new System.Drawing.Size(38, 15);
            costoLbl.TabIndex = 9;
            costoLbl.Text = "Costo";
            // 
            // CostoMdfLbl
            // 
            CostoMdfLbl.AutoSize = true;
            CostoMdfLbl.Location = new System.Drawing.Point(60, 275);
            CostoMdfLbl.Name = "CostoMdfLbl";
            CostoMdfLbl.Size = new System.Drawing.Size(38, 15);
            CostoMdfLbl.TabIndex = 10;
            CostoMdfLbl.Text = "Costo";
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(450, 339);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Seleccionar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(450, 238);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(44, 15);
            label7.TabIndex = 12;
            label7.Text = "Cliente";
            // 
            // ClienteLbl
            // 
            ClienteLbl.AutoSize = true;
            ClienteLbl.Location = new System.Drawing.Point(452, 275);
            ClienteLbl.Name = "ClienteLbl";
            ClienteLbl.Size = new System.Drawing.Size(44, 15);
            ClienteLbl.TabIndex = 13;
            ClienteLbl.Text = "Cliente";
            // 
            // DetalleHabitacion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(ClienteLbl);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(CostoMdfLbl);
            Controls.Add(costoLbl);
            Controls.Add(startTimeLabel);
            Controls.Add(endTimeLabel);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DetalleHabitacion";
            Text = "DetalleHabitacion";
            Load += DetalleHabitacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label costoLbl;
        private System.Windows.Forms.Label CostoMdfLbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ClienteLbl;
    }
}