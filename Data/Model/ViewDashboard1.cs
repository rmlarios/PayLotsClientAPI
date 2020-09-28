using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class ViewDashboard1
    {
        public string NombreProyecto { get; set; }
        public string Bloque { get; set; }
        public decimal? Pagado { get; set; }
        public string MesPagado { get; set; }
        public string Estado { get; set; }
        public int IdLote { get; set; }
        public DateTime? Far { get; set; }
        public decimal? MontoTotal { get; set; }
        public decimal? Saldo { get; set; }
        public string NombreCompleto { get; set; }
        public string NombreLote { get; set; }
        public string EstadoAsignacion { get; set; }
        public int IdUbicacion { get; set; }
    }
}
