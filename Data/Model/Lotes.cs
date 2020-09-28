using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class Lotes
    {
        public Lotes()
        {
            Asignaciones = new HashSet<Asignaciones>();
        }

        public int IdLote { get; set; }
        public int? IdBloque { get; set; }
        public string NumeroLote { get; set; }
        public decimal? Area { get; set; }
        public string Estado { get; set; }
        public string Uar { get; set; }
        public DateTime? Far { get; set; }
        public string Uua { get; set; }
        public DateTime? Fua { get; set; }

        public virtual Bloques IdBloqueNavigation { get; set; }
        public virtual ICollection<Asignaciones> Asignaciones { get; set; }
    }
}
