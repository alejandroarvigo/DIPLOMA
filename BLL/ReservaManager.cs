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
            reservaRepository.reserveRoom(reserva);
        }

        public Reserva[] getReservas() { return reservaRepository.getReservas(); }


        public void getFreeRooms(DateTime fecha1, DateTime fecha2)
        {
            Reserva[] reservas = this.getReservas();
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