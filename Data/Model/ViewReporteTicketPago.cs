﻿using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class ViewReporteTicketPago
    {
        public string NumeroRecibo { get; set; }
        public DateTime? FechaRecibo { get; set; }
        public string NumeroLote { get; set; }
        public int? NumeroAbono { get; set; }
        public string Beneficiario { get; set; }
        public string Proyecto { get; set; }
        public decimal Interes { get; set; }
        public decimal Mora { get; set; }
        public decimal? Saldo { get; set; }
        public string Cajero { get; set; }
        public string MesPagado { get; set; }
        public decimal? SaldoInicial { get; set; }
        public decimal MontoPago { get; set; }
        public decimal? Prima { get; set; }
        public int? IdAsignacion { get; set; }
        public decimal? TotalPagar { get; set; }
    }
}
