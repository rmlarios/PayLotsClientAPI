using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class ViewPagosAsignaciones
    {
        public int? IdPago { get; set; }
        public int IdAsignacion { get; set; }
        public string NombreLote { get; set; }
        public string NombreCompleto { get; set; }
        public string NumeroRecibo { get; set; }
        public DateTime? FechaRecibo { get; set; }
        public string MesPagado { get; set; }
        public decimal? MontoPago { get; set; }
        public decimal Mora { get; set; }
        public decimal Interés { get; set; }
        public decimal? TotalRecibo { get; set; }
        public int IdLote { get; set; }
        public decimal? MontoTotal { get; set; }
        public decimal Prima { get; set; }
        public decimal Abonado { get; set; }
        public decimal? Saldo { get; set; }
        public int? NumeroAbono { get; set; }
        public string Estado { get; set; }
        public string Observaciones { get; set; }
        public string NombreProyecto { get; set; }
        public int IdUbicacion { get; set; }
        public string Grupo { get; set; }
        public bool? Donado { get; set; }
        public string Moneda { get; set; }
        public decimal? TasaCambio { get; set; }
        public decimal? MontoEfectivo { get; set; }
    }
}
