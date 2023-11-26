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
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Reservas : Form, IObserver
    {
        private readonly ReservaManager reservaManager;
        ResourceManager idioma;
        public Reservas()
        {
            InitializeComponent();
            reservaManager = new ReservaManager();
            ObserverLanguage.Current.AgregarObservador(this);
            Translate();
        }

        public void Actualizar()
        {
            Translate();
        }

        private void Translate()
        {
            idioma = FacadeService.Translate(Thread.CurrentThread.CurrentCulture.Name);
            this.lblDesde.Text = idioma.GetString("Desde");
            this.lblHasta.Text = idioma.GetString("Hasta");
            this.button1.Text = idioma.GetString("Buscar");
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

                ReservaDetalle detallesForm = new ReservaDetalle(habitacionSeleccionada, dateTimePickerInicio.Value, dateTimePickerFin.Value);

                detallesForm.Show();
            }
        }

        private void HabitacionesHome_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
