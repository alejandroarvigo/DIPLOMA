using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ReporteFacturacionModel
    {

        public int CostoTotal { get; set; }

        public int CantidadReservas { get; set; }

        public int CantidadHabitaciones { get; set; }

        public string? Mes { get; set; }
    }
}
