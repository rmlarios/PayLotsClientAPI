using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class Beneficiarios
    {
        public Beneficiarios()
        {
            Asignaciones = new HashSet<Asignaciones>();
        }

        public int IdBeneficiario { get; set; }
        public string NombreCompleto { get; set; }
        public string CedulaIdentidad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        /*public string Uar { get; set; }
        public DateTime Far { get; set; }
        public string Uua { get; set; }
        public DateTime Fua { get; set; }
        */
        public virtual ICollection<Asignaciones> Asignaciones { get; set; }
    }
}
