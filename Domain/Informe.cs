using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Informe
    {
        public List<Factura> Facturas { get; set; }
        public List<Gasto> Gastos { get; set; }
    }
}
