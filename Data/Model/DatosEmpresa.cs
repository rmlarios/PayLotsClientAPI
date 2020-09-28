using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class DatosEmpresa
    {
        public int DatosEmpresaId { get; set; }
        public string NombreEmpresa { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public byte[] Logo { get; set; }
        public string Ruc { get; set; }
        public int? ReciboInicial { get; set; }
        public string Uar { get; set; }
        public DateTime? Far { get; set; }
        public string Uua { get; set; }
        public DateTime? Fua { get; set; }
    }
}
