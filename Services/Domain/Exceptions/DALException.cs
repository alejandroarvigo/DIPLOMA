using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain.Exceptions
{
    internal class DALException: Exception
    {
        public DALException(Exception ex) : base("DAL Exception", ex)
        {

        }
    }
}
