using DAL;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ReporteManager
    {
        ReservaRepository reservaRepository = new ReservaRepository();

        public List<ReporteFacturacionModel> CalcularReporteFacturacion(DateTime fechaInicio, DateTime fechaFin)
        {
            List<ReporteFacturacionModel> reportes = new List<ReporteFacturacionModel>();


            if (fechaFin > fechaInicio.AddMonths(1))
            {
                DateTime fechaActual = fechaInicio;

                while (fechaActual < fechaFin)
                {
                    DateTime fechaFinMes = new DateTime(fechaActual.Year, fechaActual.Month, DateTime.DaysInMonth(fechaActual.Year, fechaActual.Month));

                    DateTime proximoMes = fechaActual.AddMonths(1);

                    if (proximoMes > fechaFin)
                    {
                        proximoMes = fechaFin;
                    }

                    ReporteFacturacionModel reporte = reservaRepository.CalcularReporteFacturacion(fechaActual, fechaFinMes);

                    if (reporte != null) { 
                        reporte.Mes = fechaActual.ToString("MMMM");
                        reportes.Add(reporte);
                    }

                    fechaActual = proximoMes;
                }

            } else {
                ReporteFacturacionModel reporte = reservaRepository.CalcularReporteFacturacion(fechaInicio, fechaFin);

                if (reporte != null) { 
                    reporte.Mes = fechaInicio.ToString("MMMM");
                    reportes.Add(reporte); 
                }

            }

            return reportes;

        }

    }
}
