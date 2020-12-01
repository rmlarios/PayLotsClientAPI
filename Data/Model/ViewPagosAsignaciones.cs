using Data.CustomValidations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Model
{
    public partial class ViewPagosAsignaciones
    {
        public int? IdPago { get; set; }
        public int IdAsignacion { get; set; }
        public string NombreLote { get; set; }
        public string NombreCompleto { get; set; }
        public string NumeroRecibo { get; set; }
        [Required(ErrorMessage ="Debe ingresar la fecha del recibo.")]
        public DateTime? FechaRecibo { get; set; }
        [Required(ErrorMessage ="Debe seleccionar el mes a pagar.")]
        public string MesPagado { get; set; }
        public decimal? MontoPago { get; set; }
        public decimal? Mora { get; set; } = 0;
        public decimal? Interés { get; set; } = 0;
        public decimal? TotalRecibo { get; set; }
        public int IdLote { get; set; }
        public decimal? MontoTotal { get; set; }
        public decimal? Prima { get; set; } = 0;
        public decimal? Abonado { get; set; } = 0;
        [Column(TypeName= "numeric(18,2)")]
        public decimal? Saldo { get; set; }
        public int? NumeroAbono { get; set; }
        public string Estado { get; set; }
        public string Observaciones { get; set; }
        public string NombreProyecto { get; set; }
        public int IdUbicacion { get; set; }
        public string Grupo { get; set; }
        public bool? Donado { get; set; }
        [Required(ErrorMessage = "Debe seleccionar la moneda del pago.")]
        public string Moneda { get; set; } = "Córdobas";
        [CustomTasaCambioValidator]
        public decimal? TasaCambio { get; set; } = 0;
        [Required(ErrorMessage = "Debe ingresar el monto efectivo pagado.")]
        [Range(1, 1000, ErrorMessage = "Debe ingresar un monto mayor a 0")]
        public decimal? MontoEfectivo { get; set; } = 0;
    }
}
