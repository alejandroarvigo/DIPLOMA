using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Empleado
    {
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int Dni { get; set; }
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public Rol Rol { get; set; }
    }
}
