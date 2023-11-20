namespace UI
{
    partial class HabitacionesHome
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
            dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            button1 = new System.Windows.Forms.Button();
            lblDesde = new System.Windows.Forms.Label();
            lblHasta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Location = new System.Drawing.Point(35, 58);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new System.Drawing.Size(200, 23);
            dateTimePickerInicio.TabIndex = 0;
            // 
            // dateTimePickerFin
            // 
            dateTimePickerFin.Location = new System.Drawing.Point(269, 58);
            dateTimePickerFin.Name = "dateTimePickerFin";
            dateTimePickerFin.Size = new System.Drawing.Size(200, 23);
            dateTimePickerFin.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(35, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(753, 291);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellDoubleClick += DataGridViewHabitaciones_CellClick;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(35, 99);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Location = new System.Drawing.Point(35, 19);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new System.Drawing.Size(39, 15);
            lblDesde.TabIndex = 4;
            lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Location = new System.Drawing.Point(269, 19);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new System.Drawing.Size(37, 15);
            lblHasta.TabIndex = 5;
            lblHasta.Text = "Hasta";
            // 
            // HabitacionesHome
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(lblHasta);
            Controls.Add(lblDesde);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePickerFin);
            Controls.Add(dateTimePickerInicio);
            Name = "HabitacionesHome";
            Text = "Form1";
            Load += HabitacionesHome_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
    }
}