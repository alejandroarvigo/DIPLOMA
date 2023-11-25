using BLL;
using Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class ReporteFacturacion : Form
    {
        ReporteManager rm;
        public ReporteFacturacion()
        {
            InitializeComponent();
            rm = new ReporteManager();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dateTimePickerInicio.Value;
            DateTime fechaFin = dateTimePicker1.Value;

            List<ReporteFacturacionModel> repoteFacturacion = rm.CalcularReporteFacturacion(fechaInicio, fechaFin);

            if (repoteFacturacion.Count == 0)
            {
                MessageBox.Show("No hay datos en ese rango de fecha");
                return;
            }

            dataGridView1.DataSource = repoteFacturacion;

        }

        private void ReporteFacturacion_Load(object sender, EventArgs e)
        {

        }
    }
}
