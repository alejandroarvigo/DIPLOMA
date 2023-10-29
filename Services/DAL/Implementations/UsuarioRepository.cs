using Services.DAL.Tools;
using Services.Domain.Security.Composite;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Services.DAL.Implementations
{
    internal sealed class UsuarioRepository : IGenericRepository<Usuario>
    {
        #region Singleton
        private readonly static UsuarioRepository _instance = new UsuarioRepository();

        public static UsuarioRepository Current
        {
            get
            {
                return _instance;
            }
        }
        #endregion

        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Usuario] (Name, Password) VALUES (@Name, @Password)";
        }

        private string SelectOneStatement
        {
            get => "Usuario_Select";
        }

        private string LoginSelectStatement
        {
            get => "SELECT Id, Name, Password FROM [dbo].[Usuario] " +
                "WHERE Name = @Name " +
                "AND Password = @Password ";
        }

        private UsuarioRepository()
        {
            //Implement here the initialization code
        }

        public bool Add(Usuario obj)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(InsertStatement, System.Data.CommandType.Text,
                                                new SqlParameter[] { new SqlParameter("@Name", obj.Nombre), new SqlParameter("@Password", obj.Password)}))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
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

        public void Update(Usuario obj)
        {
            throw new NotImplementedException();
        }

        //Ver si puedo usar uno de los metodos expuestos x la interfaz
        public Usuario Login(Usuario obj)
        {

            if (String.IsNullOrEmpty(obj.Nombre) && String.IsNullOrEmpty(obj.Nombre)) throw new Exception();

            try
            {
                using (var reader = SqlHelper.ExecuteReader(LoginSelectStatement, System.Data.CommandType.Text,
                                                new SqlParameter[] { new SqlParameter("@Name", obj.Nombre), new SqlParameter("@Password", obj.Password) }))
                {
                    object[] values = new object[reader.FieldCount];
                    Usuario user = new Usuario();


                    if (reader.Read())
                    {
                        reader.GetValues(values);
                        user.IdUsuario = values[0].ToString();
                        user.Nombre = values[1].ToString();
                        //Patente patente = new Patente();
                        //Familia familia = new Familia();
                        return user;

                    }
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }



        }
    }
}
