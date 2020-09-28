using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class ViewReporteMorosos
    {
        public int IdAsignacion { get; set; }
        public DateTime? FechaInicioPago { get; set; }
        public string Beneficiario { get; set; }
        public string Telefono { get; set; }
        public string NombreLote { get; set; }
        public string Ubicacion { get; set; }
        public int? Cuotas { get; set; }
        public int? CuotasRequeridas { get; set; }
    }
}
