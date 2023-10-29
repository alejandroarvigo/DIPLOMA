using Services.Domain.Exceptions;
using Services.Facade;
using System.Globalization;
using System.Resources;
using System.Threading;
using Services.DAL.i18n;


namespace Services.BLL
{
    internal class LanguageManager
    {
        #region Singleton
        public readonly static LanguageManager _instance = new LanguageManager();

        public static LanguageManager Current
        {
            get
            {
                return _instance;
            }
        }

        private LanguageManager()
        {
        }
        #endregion

        public ResourceManager Translate(string cultureInfo)
        {
            try
            {
                Idioma.Culture = new CultureInfo(cultureInfo);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureInfo);

                return Idioma.ResourceManager;
            }
            catch (BLLException ex)
            {
                FacadeService.ManageException(ex);
                return null;
            }

        }
    }
}
