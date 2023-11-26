using CsvHelper.Configuration.Attributes;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ReporteDetalladoModel
    {
        [Index(0)]
        public Cliente? Cliente { get; set; }

        [Index(1)]
        public EstadoReserva Estado { get; set; }

        [Index(2)]
        public DateTime FechaFin { get; set; }

        [Index(3)]
        public DateTime FechaInicio { get; set; }

        [Index(4)]
        public Habitacion? Habitacion { get; set; }

        [Index(5)]
        public int CostoTotal { get; set; }
    }

}
