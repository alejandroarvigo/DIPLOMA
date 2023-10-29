using Services.Domain.Bitacora.EnumCriticidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain.Bitacora
{
    public class Bitacora
    {
        public DateTime Fecha { get; set; }
        public String Descripcion { get; set; }
        public CriticidadEnum Criticidad { get; set; }
        public String Usuario { get; set; }
    }
}
