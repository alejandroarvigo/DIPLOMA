using Domain;
using Domain.Enums;
using System.Configuration;
using System.Data.SqlClient;
using System.Reflection.PortableExecutable;

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

                try
                {
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
                }
                catch (Exception ex)
                {
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

        public ReporteFacturacionModel CalcularReporteFacturacion(DateTime fechaInicio, DateTime fechaFin)
        {
            ReporteFacturacionModel reporte = new ReporteFacturacionModel();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT 
                                SUM(H.Costo * DATEDIFF(day, R.FechaInicio, R.FechaFin)) as CostoTotal,
                                COUNT(*) as CantidadReservas
                             FROM [dbo].[Reservas] R
                             JOIN [dbo].[Habitaciones] H ON R.HabitacionId = H.NumeroHabitacion
                             WHERE R.FechaInicio BETWEEN @FechaInicio AND @FechaFin";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    command.Parameters.AddWithValue("@FechaFin", fechaFin);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader.IsDBNull(0) || reader.IsDBNull(1)) return null;

                        reporte.CostoTotal = reader.GetInt32(0);
                        reporte.CantidadReservas = reader.GetInt32(1);
                    }

                    reader.Close();
                }

                string queryHabitaciones = "SELECT COUNT(DISTINCT HabitacionId) FROM Reservas WHERE FechaInicio BETWEEN @FechaInicio AND @FechaFin";

                using (SqlCommand commandHabitaciones = new SqlCommand(queryHabitaciones, connection))
                {
                    commandHabitaciones.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    commandHabitaciones.Parameters.AddWithValue("@FechaFin", fechaFin);

                    reporte.CantidadHabitaciones = (int)commandHabitaciones.ExecuteScalar();
                }
            }

            return reporte;
        }

        public List<ReporteDetalladoModel> ObtenerDetallesReporte(string mes)
        {

            List<ReporteDetalladoModel> reporteDetalladoModels = new List<ReporteDetalladoModel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $@"SELECT 
                        R.*,
                        C.*,
                        H.*,
                        H.Costo * DATEDIFF(day, R.FechaInicio, R.FechaFin) as CostoTotal
                    FROM [dbo].[Reservas] R
                    JOIN [dbo].[Clientes] C ON R.ClienteDni = C.Dni
                    JOIN [dbo].[Habitaciones] H ON R.HabitacionId = H.NumeroHabitacion
                    WHERE FORMAT(R.FechaInicio, 'MMMM') = @Mes";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Mes", mes);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ReporteDetalladoModel detalleReserva = new ReporteDetalladoModel
                        {
                            FechaInicio = reader.GetDateTime(reader.GetOrdinal("FechaInicio")),
                            FechaFin = reader.GetDateTime(reader.GetOrdinal("FechaFin")),
                            CostoTotal = reader.GetInt32(reader.GetOrdinal("CostoTotal")),
                        };

                        Habitacion detalleHabitacion = new Habitacion
                        {
                            NumeroHabitacion = reader.GetInt32(reader.GetOrdinal("NumeroHabitacion")),
                            Capacidad = reader.GetInt32(reader.GetOrdinal("Capacidad")),
                            Detalle = reader.GetString(reader.GetOrdinal("Detalle")),
                        };

                        Cliente detalleCliente = new Cliente
                        {
                            Dni = reader.GetInt32(reader.GetOrdinal("Dni")),
                            Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                            Apellido = reader.GetString(reader.GetOrdinal("Apellido")),
                            FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento")),
                        };

                        detalleReserva.Cliente = detalleCliente;
                        detalleReserva.Habitacion = detalleHabitacion;
                        reporteDetalladoModels.Add(detalleReserva);
                    }

                    reader.Close();
                }
            }

            return reporteDetalladoModels;
        }
    }

}