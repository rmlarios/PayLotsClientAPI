using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class ViewTotalAbonadoAsignaciones
    {
        public decimal? Abonado { get; set; }
        public int? Cuotas { get; set; }
        public string Estado { get; set; }
        public int IdAsignacion { get; set; }
        public string NumeroLote { get; set; }
    }
}
