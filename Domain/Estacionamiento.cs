using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Estacionamiento
    {
        public int Costo { get; set; }
        public int Id { get; set; }
        public EstacionamientoSize EstacionamientoSize { get; set; }
        public int Slot { get; set; }
    }
}
