using Services.DAL.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.DAL.i18n
{
    public class ObserverLanguage
    {
        string cultureInfo = Thread.CurrentThread.CurrentUICulture.Name;
        private List<IObserver> observadores = new List<IObserver>();

        #region Singleton
        private readonly static ObserverLanguage _instance = new ObserverLanguage();

        public static ObserverLanguage Current
        {
            get
            {
                return _instance;
            }
        }

        private ObserverLanguage()
        {
        }

        #endregion
        public void AgregarObservador(IObserver observador)
        {
            observadores.Add(observador);
        }

        public void NotificarObservadores()
        {
            foreach (var observador in observadores)
            {
                observador.Actualizar();
            }
        }
    }

}


