using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class ViewConsolidadoBloques
    {
        public int IdUbicacion { get; set; }
        public string NombreProyecto { get; set; }
        public int? IdMunicipio { get; set; }
        public string Direccion { get; set; }
        public int IdBloque { get; set; }
        public string Bloque { get; set; }
        public int? Disponibles { get; set; }
        public int? Asignados { get; set; }
    }
}
