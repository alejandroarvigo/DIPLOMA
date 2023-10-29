using DAL;
using Domain;
using System.Globalization;

namespace BLL
{
    public class ReservaManager
    {

        ReservaRepository reservaRepository = new ReservaRepository();
        public void reserveRoom(Reserva reserva)
        {
            if (reserva == null)
            {
                throw new ArgumentNullException("reserva", "La reserva no puede ser nula.");
            }

            if (reserva.FechaInicio == null || reserva.FechaFin == null)
            {
                throw new ArgumentException("Las fechas de inicio y fin son obligatorias.");
            }

            if (reserva.Cliente == null)
            {
                throw new ArgumentException("El cliente es obligatorio para realizar una reserva.");
            }

            if (reserva.Habitacion == null)
            {
                throw new ArgumentException("La habitación es obligatoria para realizar una reserva.");
            }

            reservaRepository.reserveRoom(reserva);
        }

        public Habitacion[] GetHabitacionesDisponiblesBetweenDates(DateTime fechaInicio, DateTime fechaFin)
        {

            DateTime fechaActual = DateTime.Today;

            if (fechaInicio < fechaActual)
            {
                throw new Exception("La fecha de inicio no puede ser menor que la fecha actual.");
            }
            else if (fechaFin < fechaActual)
            {
                throw new Exception("La fecha de fin no puede ser menor que la fecha actual.");
            }
            if (fechaFin < fechaInicio)
            {
                throw new Exception("La fecha de fin no puede ser menor que la fecha de inicio.");
            }   


            return reservaRepository.getHabitacionesDisponiblesBetweenDates(fechaInicio, fechaFin);
        }


    }
}