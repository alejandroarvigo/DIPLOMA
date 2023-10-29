using Services.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    public static class FacadeService
    {
        public static void ManageException(Exception ex)
        {
            ExceptionManager.Current.Handle(ex);
        }

        public static ResourceManager Translate(string cultureInfo)
        {
            return LanguageManager.Current.Translate(cultureInfo);
        }
    }
}
