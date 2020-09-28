using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class Proformas
    {
        public int IdProforma { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Proyecto { get; set; }
        public string Lote { get; set; }
        public decimal? Area { get; set; }
        public decimal? PrecioVara { get; set; }
        public decimal? Total { get; set; }
        public decimal? Prima { get; set; }
        public int? Interes { get; set; }
        public int? Plazo { get; set; }
        public decimal? Financiar { get; set; }
        public decimal? Cuota { get; set; }
        public decimal? InteresAcumulado { get; set; }
        public decimal? TotalApagar { get; set; }
        public string Uar { get; set; }
        public DateTime Far { get; set; }
        public string Uua { get; set; }
        public DateTime Fua { get; set; }
    }
}
