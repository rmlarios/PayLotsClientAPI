using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class ViewConsolidadoUbicaciones
    {
        public int IdUbicacion { get; set; }
        public string NombreProyecto { get; set; }
        public int? IdMunicipio { get; set; }
        public string Direccion { get; set; }
        public int? Bloques { get; set; }
        public int? Asignados { get; set; }
        public int? Diponibles { get; set; }
        public bool? AplicaInteres { get; set; }
        public string Proyecto { get; set; }
    }
}
