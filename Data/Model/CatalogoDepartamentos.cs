using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class CatalogoDepartamentos
    {
        public CatalogoDepartamentos()
        {
            CatalogoMunicipios = new HashSet<CatalogoMunicipios>();
        }

        public int DepartamentoId { get; set; }
        public string Descripcion { get; set; }
        public string Uua { get; set; }
        public DateTime Fua { get; set; }
        public string Uar { get; set; }
        public DateTime Far { get; set; }

        public virtual ICollection<CatalogoMunicipios> CatalogoMunicipios { get; set; }
    }
}
