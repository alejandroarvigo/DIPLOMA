using Services.DAL.Tools;
using Services.Domain.Security.Composite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Services.DAL.Implementations
{
    public class UsuarioRepository : IGenericRepository<Usuario>
    {
        private readonly string connectionString;

        public UsuarioRepository()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["PermisosConString"].ConnectionString;
        }

        public bool Add(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public Usuario Login(Usuario obj)
        {
            if (String.IsNullOrEmpty(obj.NameUsuario) || String.IsNullOrEmpty(obj.Password))
            {
                throw new Exception("UsuarioNombre y PasswordHash no pueden ser nulos o vacíos.");
            }

            Usuario usuario = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Usuarios WHERE Usuario = @Usuario AND PasswordHash = @PasswordHash";
                    command.Parameters.AddWithValue("@Usuario", obj.NameUsuario);
                    command.Parameters.AddWithValue("@PasswordHash", obj.Password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new Usuario
                            {
                                IdUsuario = reader["UsuarioID"].ToString(),
                                NameUsuario = reader["Usuario"].ToString(),
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                Email = reader["Email"].ToString(),
                                Dgv = Convert.ToInt32(reader["DigitoVerificador"]),
                                DefaultLangague = reader["IdiomaDefault"].ToString()
                            };

                            usuario.Permisos = GetPermisosByUsuarioID(Convert.ToInt32(usuario.IdUsuario));
                        }
                    }
                }
            }

            return usuario;
        }

        public void Update(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Usuario SelectOne(Guid id)
        {
            throw new NotImplementedException();
        }

        private List<Component> GetPermisosByUsuarioID(int usuarioID)
        {
            List<Component> permisos = new List<Component>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT P.* FROM Patentes P " +
                                          "JOIN Usuarios_Patentes UP ON P.PantallaID = UP.PantallaID " +
                                          "WHERE UP.UsuarioID = @UsuarioID";
                    command.Parameters.AddWithValue("@UsuarioID", usuarioID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patente permiso = new Patente
                            {
                                FormName = reader["NombrePantalla"].ToString()
                            };

                            permisos.Add(permiso);
                        }
                    }
                }
            }

            return permisos;
        }
    }
}
