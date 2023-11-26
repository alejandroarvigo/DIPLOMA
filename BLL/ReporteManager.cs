using CsvHelper;
using DAL;
using Domain;
using Services.Facade;
using System.Globalization;
using System.Resources;

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

        public void GenerarYDescargarCSV(string mes)
        {
            ResourceManager idioma = FacadeService.Translate("en-US");

            var selectedMonth = idioma.GetString(mes);

            if (selectedMonth == null) return;

            var listaReports = reservaRepository.ObtenerDetallesReporte(selectedMonth);

            if (listaReports == null || listaReports.Count == 0)
            {
                return;
            }

            

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string csvFileName = Path.Combine(desktopPath, "ReporteDetallado.csv");

            using (TextWriter writer = new StreamWriter(csvFileName))
            {
                var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);

   
                csv.WriteHeader<ReporteDetalladoModel>();
                csv.NextRecord();
                csv.WriteRecords(listaReports);
            }

            Console.WriteLine($"Archivo CSV '{csvFileName}' generado con éxito.");
        }


    }
}
