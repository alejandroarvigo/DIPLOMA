using Services.DAL.Implementations;
using Services.Domain.Bitacora;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DAL.Factory
{
    public class FactoryDAL
    {
        #region Singleton

        private readonly static FactoryDAL instance = new FactoryDAL();

        public static FactoryDAL Current
        {
            get
            {
                return instance;
            }
        }

        private FactoryDAL()
        {
            //Implement here the initialization code
        }
        #endregion

        public UsuarioRepository GetUsersRepository()
        {
            string nombreNamespaceClaseAccesoDatos = ConfigurationManager.AppSettings["AccesoDatos"] + ".UsuarioRepository";
            object instancia = Activator.CreateInstance(Type.GetType(nombreNamespaceClaseAccesoDatos));

            return instancia as UsuarioRepository;
        }

        public BitacoraRepository GetBitacorasRepository()
        {
            string nombreNamespaceClaseAccesoDatos = ConfigurationManager.AppSettings["AccesoDatos"] + ".BitacoraRepository";
            object instancia = Activator.CreateInstance(Type.GetType(nombreNamespaceClaseAccesoDatos));

            return instancia as BitacoraRepository;
        }
    }
}
