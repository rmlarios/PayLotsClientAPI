using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class Pagos
    {
        public int IdPago { get; set; }
        public int IdAsignacion { get; set; }
        public int? NumeroAbono { get; set; }
        public string NumeroRecibo { get; set; }
        public DateTime? FechaRecibo { get; set; }
        public string MesPagado { get; set; }
        public decimal MontoPago { get; set; }
        public decimal? Mora { get; set; }
        public decimal? Interés { get; set; }
        public string Moneda { get; set; }
        public decimal? TasaCambio { get; set; }
        public decimal? MontoEfectivo { get; set; }
        public string Observaciones { get; set; }
        public string Uar { get; set; }
        public DateTime Far { get; set; }
        public string Uua { get; set; }
        public DateTime Fua { get; set; }

        public virtual Asignaciones IdAsignacionNavigation { get; set; }
    }
}
