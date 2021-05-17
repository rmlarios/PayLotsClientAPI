using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevExtremeAspNetCoreResponsiveApp.DTOs
{
    public class TicketPrima
    {
        public DateTime Fecha { get; set; }
        public string NombreLote { get; set; }
        public string Beneficiario { get; set; }
        public string NombreProyecto { get; set; }
        public double SaldoInicial { get; set; }
        public double MontoPago { get; set; }
        public double Saldo { get; set; }
        public string Cajero { get; set; }
    }
}
