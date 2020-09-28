using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class ViewReportePlanPago
    {
        public int? IdAsignacion { get; set; }
        public string Proyecto { get; set; }
        public string NumeroLote { get; set; }
        public decimal? AreaLote { get; set; }
        public decimal? Total { get; set; }
        public decimal? Prima { get; set; }
        public string Beneficiario { get; set; }
        public int? NumeroCuota { get; set; }
        public DateTime? FechaCuota { get; set; }
        public string MesPagado { get; set; }
        public decimal? SaldoInicial { get; set; }
        public decimal? MontoMinimo { get; set; }
        public decimal? Saldo { get; set; }
        public decimal? Interes { get; set; }
        public decimal? TotalPagar { get; set; }
        public decimal? MontoPagado { get; set; }
        public string FechaPago { get; set; }
        public string Estado { get; set; }
        public decimal? Mora { get; set; }
    }
}
