using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DAL
{
    internal interface IGenericRepository<T>
    {
        bool Add(T obj);

        void Update(T obj);

        void Delete(Guid id);

        IEnumerable<T> SelectAll();

        T SelectOne(Guid id);
    }
}
