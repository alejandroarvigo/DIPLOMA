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
    public partial class ReservaDetalle : Form
    {
        private readonly ReservaManager reservaManager;

        private Habitacion habitacionSeleccionada;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private Cliente cliente;
        public ReservaDetalle(Habitacion habitacion, DateTime inicio, DateTime fin)
        {
            InitializeComponent();
            reservaManager = new ReservaManager();
            this.habitacionSeleccionada = habitacion;
            this.fechaInicio = inicio;
            this.fechaFin = fin;
        }

        private void DetalleHabitacion_Load(object sender, EventArgs e)
        {
            label3.Text = habitacionSeleccionada.NumeroHabitacion.ToString();
            label4.Text = habitacionSeleccionada.Detalle.ToString();

            startTimeLabel.Text = "Fecha de Inicio: " + fechaInicio.ToString("yyyy-MM-dd");
            endTimeLabel.Text = "Fecha de Fin: " + fechaFin.ToString("yyyy-MM-dd");

            int cantidadNoches = (int)(fechaFin - fechaInicio).TotalDays;
            decimal importeTotal = habitacionSeleccionada.Costo * cantidadNoches;


            CostoMdfLbl.Text = "Importe Total: $" + importeTotal.ToString("0.00");

            if (cliente == null)
            {
                ClienteLbl.Text = "Tenés que seleccionar un cliente";
            }
            else
            {
                ClienteLbl.Text = "Cliente: " + cliente.Nombre + " " + cliente.Apellido;
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            SeleccionCliente detallesForm = new SeleccionCliente();

            detallesForm.ShowDialog();

            if (detallesForm.ClienteSeleccionado != null)
            {

                cliente = detallesForm.ClienteSeleccionado;

            }
            DetalleHabitacion_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Reserva newReserva = new Reserva()
                {
                    Cliente = cliente,
                    FechaInicio = fechaInicio,
                    FechaFin = fechaFin,
                    Estado = Domain.Enums.EstadoReserva.Reservada,
                    Habitacion = habitacionSeleccionada
                };

                reservaManager.reserveRoom(newReserva);

                MessageBox.Show("Se realizo la reserva con exito");

            }
            catch (Exception ex)
            {

            }
        }
    }
}
