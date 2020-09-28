using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class Asignaciones
    {
        public Asignaciones()
        {
            Pagos = new HashSet<Pagos>();
        }

        public int IdAsignacion { get; set; }
        public int IdLote { get; set; }
        public int IdBeneficiario { get; set; }
        public DateTime? FechaInicioPago { get; set; }
        public int? DiaCuota { get; set; }
        public decimal? MontoTotal { get; set; }
        public decimal? CuotaMinima { get; set; }
        public decimal? Prima { get; set; }
        public string Estado { get; set; }
        public bool? Donado { get; set; }
        public bool? AplicaInteres { get; set; }
        public decimal? TasaInteres { get; set; }
        public bool? AplicaMora { get; set; }
        public int? Plazo { get; set; }
        public string Observaciones { get; set; }
        public string Uar { get; set; }
        public DateTime Far { get; set; }
        public string Uua { get; set; }
        public DateTime Fua { get; set; }

        public virtual Beneficiarios IdBeneficiarioNavigation { get; set; }
        public virtual Lotes IdLoteNavigation { get; set; }
        public virtual ICollection<Pagos> Pagos { get; set; }
    }
}
