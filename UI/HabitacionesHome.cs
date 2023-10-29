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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaInicio = dateTimePickerInicio.Value;
                DateTime fechaFin = dateTimePickerFin.Value;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView1.DataSource =
                    reservaManager.GetHabitacionesDisponiblesBetweenDates(fechaInicio, fechaFin);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void DataGridViewHabitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Habitacion habitacionSeleccionada = (Habitacion)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                ReservaDetalle detallesForm = new ReservaDetalle(habitacionSeleccionada,dateTimePickerInicio.Value, dateTimePickerFin.Value);

                detallesForm.Show();
            }
        }

    }
}
