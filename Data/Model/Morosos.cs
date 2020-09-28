using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class Morosos
    {
        public int? IdAsignacion { get; set; }
        public string Beneficiario { get; set; }
        public string Telefono { get; set; }
        public string NombreLote { get; set; }
        public string Ubicacion { get; set; }
        public int? CuotasVencidas { get; set; }
        public string MesesVencidos { get; set; }
        public decimal? MontoCuotasVencidas { get; set; }
        public decimal? InteresAcumulado { get; set; }
        public decimal? MoraAcumulada { get; set; }
        public DateTime? FechaGenerado { get; set; }
    }
}
