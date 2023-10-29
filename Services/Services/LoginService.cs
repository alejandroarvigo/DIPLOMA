using Services.DAL.Tools;
using Services.Domain.Security.Composite;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public static class LoginService
    {
        public static bool Register(Usuario usuario)
        {
            return DAL.Implementations.UsuarioRepository.Current.Add(usuario);
        }
        public static bool Login(Usuario usuario)
        {
            try {
                DAL.Implementations.UsuarioRepository.Current.Login(usuario);
                return true;
            }
            catch (Exception ex){
                return false;
            }
 
        }

        public static Patente SelectOnePatente(Guid id)
        {
            return null;
            //return DAL.Implementations.PatenteRepository.Current.SelectOne(id);
        }

        public static Usuario SelectOneUsuario(Guid id)
        {
            return null;
            //return DAL.Implementations.UsuarioRepository.Current.SelectOne(id);
        }

        public static IEnumerable<Patente> SelectAllPatentes()
        {
            return null;
            //return DAL.Implementations.PatenteRepository.Current.SelectAll();
        }

        public static Familia SelectOneFamilia(Guid id)
        {
            return null;
            //return DAL.Implementations.FamiliaRepository.Current.SelectOne(id);
        }

    }
}
