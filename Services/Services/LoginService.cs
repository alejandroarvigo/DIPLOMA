using Services.DAL.Factory;
using Services.DAL.Implementations;
using Services.DAL.Tools;
using Services.Domain.Security.Composite;
using System;
using System.Collections.Generic;

namespace Services.Services
{
    public class LoginService
    {

        #region Singleton
        private readonly static LoginService _instance = new LoginService();
        private FactoryDAL instancia;

        public static LoginService Current
        {
            get
            {
                return _instance;
            }
        }

        private LoginService()
        {
            instancia = FactoryDAL.Current;
        }
        #endregion


        public bool Register(Usuario usuario)
        {
            //return DAL.Implementations.UsuarioRepository.Current.Add(usuario);
            return false;
        }
        public Usuario Login(Usuario usuario)
        {
           return instancia.GetUsersRepository().Login(usuario);
        }

    }
}
