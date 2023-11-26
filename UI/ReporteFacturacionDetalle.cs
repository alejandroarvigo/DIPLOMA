using BLL;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ReporteFacturacionDetalle : Form
    {
        ReporteManager rm;
        ReporteFacturacionModel reporte;
        public ReporteFacturacionDetalle(ReporteFacturacionModel reporte)
        {
            InitializeComponent();
            rm = new ReporteManager();
            this.reporte = reporte;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rm.GenerarYDescargarCSV(reporte.Mes);
        }
    }
}
