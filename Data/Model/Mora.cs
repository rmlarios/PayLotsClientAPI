using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class Mora
    {
        public int IdMora { get; set; }
        public int? Minimo { get; set; }
        public int? Maximo { get; set; }
        public decimal? Porcentaje { get; set; }
        public string Uar { get; set; }
        public DateTime? Far { get; set; }
        public string Uua { get; set; }
        public DateTime? Fua { get; set; }
    }
}
