using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Factura
    {
        public Empleado Empleado { get; set; }
        public DateTime Fecha { get; set; }
        public MetodoDePago MetodoDePago { get; set; }
        public int MontoTotal { get; set; }
        public Reserva Reserva { get; set; }
        public TipoFactura TipoFactura { get; set; }
    }
}
