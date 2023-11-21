using Services.Domain.Bitacora;
using Services.Domain.Exceptions;
using Services.Facade;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Services.DAL.Implementations
{
    public class BitacoraRepository : IGenericRepository<Bitacora>
    {

        private static string archivo = "C:\\Users\\alear\\Desktop\\criticos.json";
        public bool Add(Bitacora obj)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(obj);
                File.AppendAllText(archivo, jsonString + Environment.NewLine);
                return true;
            }
            catch (Exception ex)
            {
                FacadeService.ManageException(new DALException(ex));
                return false;
            }
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Bitacora> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Bitacora SelectOne(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Bitacora obj)
        {
            throw new NotImplementedException();
        }
    }
}
