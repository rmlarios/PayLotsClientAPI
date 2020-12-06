using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class ViewAsignacionesLotes
    {
        public int IdAsignacion { get; set; }
        public int IdLote { get; set; }
        public string NombreLote { get; set; }
        public int IdBeneficiario { get; set; }
        public string NombreCompleto { get; set; }
        public DateTime? FechaInicioPago { get; set; }
        public int? DiaCuota { get; set; }
        public decimal? MontoTotal { get; set; }
        public decimal? CuotaMinima { get; set; }
        public string Estado { get; set; }
        public bool? Donado { get; set; }
        public string CedulaIdentidad { get; set; }
        public string NombreProyecto { get; set; }
        public bool? AplicaInteres { get; set; }
        public string Observaciones { get; set; }
        public decimal Prima { get; set; }
        public decimal? Area { get; set; }
        public string Municipio { get; set; }
        public string Departamento { get; set; }
        public string Identidad { get; set; }
        public string Telefono { get; set; }
        public decimal TasaInteres { get; set; }
        public bool AplicaMora { get; set; }
        public int Plazo { get; set; }
        public int IdUbicacion { get; set; }
        public string Grupo { get; set; } = "";
        public string DatoCompleto
        {
            get { return NombreLote + (Grupo != "" ? " " + Grupo : "") + " - " + NombreCompleto; }
        }
    }
}
