using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Model
{
    public partial class Proformas
    {
        public int IdProforma { get; set; }
        [Required(ErrorMessage = "Debe ingresar el nombre del cliente")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe ingresar el domicilio del cliente")]
        public string Domicilio { get; set; }
        [Required(ErrorMessage = "Debe ingresar el teléfono del cliente")]
        public string Telefono { get; set; }
        public string Email { get; set; } = "";
        [Required(ErrorMessage = "Debe seleccionar el proyecto")]
        public string Proyecto { get; set; }
        [Required(ErrorMessage = "Debe ingresar el número del Lote")]
        public string Lote { get; set; }
        [Required(ErrorMessage = "Debe ingresar el área del Lote")]
        public decimal? Area { get; set; } = 0;
        [Required(ErrorMessage = "Debe ingresar el área del Lote")]
        public decimal? PrecioVara { get; set; } = 0;
        [Display(Name ="Valor del Lote")]
        public decimal? Total { get; set; }        
        public decimal? Prima { get; set; } = 0;
        [Required(ErrorMessage = "Debe ingresar la Tasa de Interés a aplicar")]
        [Display(Name = "Tasa de Interés")]
        public int? Interes { get; set; } = 0;
        [Required(ErrorMessage = "Debe ingresar el Plazo del Financiamiento")]
        [Display(Name ="Plazo (meses)")]
        public int? Plazo { get; set; } = 0;
        [Display(Name = "A Financiar")]
        public decimal? Financiar { get; set; }
        [Display(Name = "Cuota Mensual")]
        public decimal? Cuota { get; set; } = 0;
        [Display(Name = "Interés a Pagar")]
        public decimal? InteresAcumulado { get; set; } = 0;
        [Display(Name = "Valor Final a Pagar")]
        public decimal? TotalApagar { get; set; }
        public string Uar { get; set; }
        public DateTime Far { get; set; }
        public string Uua { get; set; }
        public DateTime Fua { get; set; }
    }
}
