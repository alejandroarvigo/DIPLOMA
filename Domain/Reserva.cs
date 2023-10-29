using Domain.Enums;

namespace Domain
{
    public class Reserva
    {
        public List<Actividad> Actividades { get; set; }
        public Cliente Cliente { get; set; }
        public List<Empleado> Empleados { get; set; }
        public Estacionamiento Estacionamiento { get; set; }
        public EstadoReserva Estado { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime FechaInicio { get; set; }
        public Habitacion Habitacion { get; set; }
    }
}