using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Gasto
    {
        public bool Autorizado { get; set; }
        public string Descripcion { get; set; }
        public Empleado Empleado { get; set; }
        public DateTime Fecha { get; set; }
        public int Monto { get; set; }
        public Proveedor Proveedor { get; set; }
    }
}
