using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class ViewBloquesUbicacion
    {
        public int IdUbicacion { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }
        public string Direccion { get; set; }
        public string Bloque { get; set; }
        public int IdBloque { get; set; }
        public int? IdMunicipio { get; set; }
        public string NombreProyecto { get; set; }
    }
}
