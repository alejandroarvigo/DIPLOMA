using Domain;
using Domain.Enums;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class ReservaRepository
    {
        private string connectionString;

        public ReservaRepository()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["ServicesConString"].ConnectionString;
        }

        public void reserveRoom(Reserva reserva)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                try {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("INSERT INTO Reservas (FechaInicio, FechaFin, Estado, HabitacionId, ClienteDni) VALUES (@FechaInicio, @FechaFin, @Estado, @HabitacionId, @ClienteDni)", connection))
                    {
                        command.Parameters.AddWithValue("@FechaInicio", reserva.FechaInicio);
                        command.Parameters.AddWithValue("@FechaFin", reserva.FechaFin);
                        command.Parameters.AddWithValue("@Estado", reserva.Estado); // Convierte el valor Enum a int
                        command.Parameters.AddWithValue("@HabitacionId", reserva.Habitacion.NumeroHabitacion);
                        command.Parameters.AddWithValue("@ClienteDni", reserva.Cliente.Dni);

                        command.ExecuteNonQuery();
                    }
                } catch (Exception ex) {
                    Console.WriteLine(ex.ToString());
                }

            }
        }

        public Reserva[] getReservas()
        {
            List<Reserva> reservas = new List<Reserva>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Reservas";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Reserva reserva = new Reserva
                            {
                                FechaInicio = Convert.ToDateTime(reader["FechaInicio"]),
                                FechaFin = Convert.ToDateTime(reader["FechaFin"]),
                                Estado = (EstadoReserva)Convert.ToInt32(reader["Estado"]),
                                Habitacion = new Habitacion
                                {
                                    NumeroHabitacion = Convert.ToInt32(reader["HabitacionId"])
                                },
                                Cliente = new Cliente
                                {
                                    Dni = Convert.ToInt32(reader["ClienteDni"])
                                }
                            };

                            reservas.Add(reserva);
                        }
                    }
                }
            }

            return reservas.ToArray();
        }


        public Habitacion[] getHabitacionesDisponiblesBetweenDates(DateTime from, DateTime to)
        {
            List<Habitacion> habitacionesDisponibles = new List<Habitacion>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Habitaciones WHERE NumeroHabitacion NOT IN (SELECT HabitacionId FROM Reservas WHERE (@FechaInicio <= FechaFin) AND (@FechaFin >= FechaInicio))";
                    command.Parameters.AddWithValue("@FechaInicio", from);
                    command.Parameters.AddWithValue("@FechaFin", to);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Habitacion habitacion = new Habitacion
                            {
                                NumeroHabitacion = Convert.ToInt32(reader["NumeroHabitacion"]),
                                Costo = Convert.ToInt32(reader["Costo"]),
                                Capacidad = Convert.ToInt32(reader["Capacidad"]),
                                Detalle = reader["Detalle"].ToString()

                            };

                            habitacionesDisponibles.Add(habitacion);
                        }
                    }
                }
            }

            return habitacionesDisponibles.ToArray();
        }

    }
}