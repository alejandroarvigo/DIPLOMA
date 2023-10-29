using BLL;
using Domain;
using Services.DAL.i18n;
using Services.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class HabitacionesHome : Form
    {
        private readonly ReservaManager reservaManager;

        public HabitacionesHome()
        {
            InitializeComponent();
            reservaManager = new ReservaManager();
        }

        private void button1_Click(object sender, EventArgs e) { 

            DateTime fechaInicio = dateTimePickerInicio.Value;
            DateTime fechaFin = dateTimePickerFin.Value;

            dataGridView1.DataSource = reservaManager.GetHabitacionesDisponiblesBetweenDates(fechaInicio, fechaFin);

        }
    }
}
