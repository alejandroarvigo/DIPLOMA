using Services.DAL.Factory;
using Services.Domain.Bitacora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BLL
{
    public class BitacoraManager
    {
        #region Singleton
        private readonly static BitacoraManager _instance = new BitacoraManager();

        public static BitacoraManager Current
        {
            get
            {
                return _instance;
            }
        }

        private BitacoraManager()
        {
        }
        #endregion

        public void Registrar(Bitacora bitacora)
        {
            FactoryDAL.Current.GetBitacorasRepository().Add(bitacora);
        }
    }
}
