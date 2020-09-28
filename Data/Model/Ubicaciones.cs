using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class Ubicaciones
    {
        public Ubicaciones()
        {
            Bloques = new HashSet<Bloques>();
        }

        public int IdUbicacion { get; set; }
        public int? IdMunicipio { get; set; }
        public string NombreProyecto { get; set; }
        public string Direccion { get; set; }
        public bool? AplicaInteres { get; set; }
        public string Uar { get; set; }
        public DateTime Far { get; set; }
        public string Uua { get; set; }
        public DateTime Fua { get; set; }

        public virtual ICollection<Bloques> Bloques { get; set; }
    }
}
