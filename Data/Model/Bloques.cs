using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class Bloques
    {
        public Bloques()
        {
            Lotes = new HashSet<Lotes>();
        }

        public int IdBloque { get; set; }
        public int IdUbicacion { get; set; }
        public string Bloque { get; set; }
        public string Observaciones { get; set; }
        public string Uar { get; set; }
        public DateTime Far { get; set; }
        public string Uua { get; set; }
        public DateTime Fua { get; set; }

        public virtual Ubicaciones IdUbicacionNavigation { get; set; }
        public virtual ICollection<Lotes> Lotes { get; set; }
    }
}
