using Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClienteRepository
    {
        private string connectionString;

        public ClienteRepository()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["ServicesConString"].ConnectionString;
        }
        public List<Cliente> GetAllClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Clientes";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cliente cliente = new Cliente
                            {
                                Dni = Convert.ToInt32(reader["Dni"]),
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                FechaNacimiento = (DateTime)reader["FechaNacimiento"]
                            };

                            clientes.Add(cliente);
                        }
                    }
                }
            }

            return clientes;
        }

    }
}
