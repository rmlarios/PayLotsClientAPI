using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class ViewAsignacionesSaldo
    {
        public int IdAsignacion { get; set; }
        public int IdLote { get; set; }
        public string NombreProyecto { get; set; }
        public string NombreLote { get; set; }
        public string NombreCompleto { get; set; }
        public decimal? MontoTotal { get; set; }
        public DateTime? FechaInicioPago { get; set; }
        public decimal? CuotaMinima { get; set; }
        public string Estado { get; set; }
        public bool? Donado { get; set; }
        public decimal Abonado { get; set; }
        public decimal? Saldo { get; set; }
        public int IdBeneficiario { get; set; }
        public bool? AplicaInteres { get; set; }
        public string Observaciones { get; set; }
        public decimal Prima { get; set; }
        public string Municipio { get; set; }
        public string Departamento { get; set; }
        public decimal TasaInteres { get; set; }
        public bool AplicaMora { get; set; }
        public int Plazo { get; set; }
    }
}
