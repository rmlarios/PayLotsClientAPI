using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class ViewLotes
    {
        public string Municipio { get; set; }
        public string Bloque { get; set; }
        public string NumeroLote { get; set; }
        public decimal? Area { get; set; }
        public string Estado { get; set; }
        public int IdLote { get; set; }
        public string NombreLote { get; set; }
        public int IdBloque { get; set; }
        public int? IdMunicipio { get; set; }
        public string Departamento { get; set; }
        public string NombreProyecto { get; set; }
        public string EstadoActual { get; set; }
        public int IdUbicacion { get; set; }
        public string Observaciones { get; set; }
    }
}
