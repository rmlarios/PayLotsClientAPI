using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Model
{
    public partial class DatosEmpresa
    {
        public int DatosEmpresaId { get; set; }
        [Required]
        public string NombreEmpresa { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public string Telefono { get; set; }
        [EmailAddress]
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
