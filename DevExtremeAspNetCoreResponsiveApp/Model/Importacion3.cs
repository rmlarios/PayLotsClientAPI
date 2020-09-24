using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevExtremeAspNetCoreResponsiveApp.Model
{
    public partial class Importacion3
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("BLOQUE")]
        public string Bloque { get; set; }
        [Column("GRUPO")]
        public string Grupo { get; set; }
        [Column("LOTE")]
        public string Lote { get; set; }
        [Column("BENEFICIARIO")]
        public string Beneficiario { get; set; }
        [Column("CEDULA")]
        public string Cedula { get; set; }
        [Column("DONADO")]
        public string Donado { get; set; }
        [Column("COSTOTOTAL", TypeName = "numeric(18, 2)")]
        public decimal? Costototal { get; set; }
        [Column("CUOTA", TypeName = "numeric(18, 2)")]
        public decimal? Cuota { get; set; }
        [Column("PLAZO DETERMINADO ")]
        public string PlazoDeterminado { get; set; }
        [Column("FECHAINICIOPAGO", TypeName = "datetime")]
        public DateTime? Fechainiciopago { get; set; }
        [Column("CULMINACION", TypeName = "numeric(18, 2)")]
        public decimal? Culminacion { get; set; }
        [Column("RECAUDADO")]
        public string Recaudado { get; set; }
        [Column("TELEFONO")]
        public string Telefono { get; set; }
        [Column("DIRECCION")]
        public string Direccion { get; set; }
        [Column("AREA", TypeName = "numeric(18, 2)")]
        public decimal? Area { get; set; }
        [Column("ERRORES")]
        public string Errores { get; set; }
        [Column("TOTAL1", TypeName = "numeric(18, 2)")]
        public decimal? Total1 { get; set; }
        [Column("MontoSEP2018", TypeName = "numeric(18, 2)")]
        public decimal? MontoSep2018 { get; set; }
        [Column("ReciboSEP2018")]
        public string ReciboSep2018 { get; set; }
        [Column("FechaSEP2018", TypeName = "datetime")]
        public DateTime? FechaSep2018 { get; set; }
        [Column("MontoOCT2018", TypeName = "numeric(18, 2)")]
        public decimal? MontoOct2018 { get; set; }
        [Column("ReciboOCT2018")]
        public string ReciboOct2018 { get; set; }
        [Column("FechaOCT2018", TypeName = "datetime")]
        public DateTime? FechaOct2018 { get; set; }
        [Column("MontoNOV2018", TypeName = "numeric(18, 2)")]
        public decimal? MontoNov2018 { get; set; }
        [Column("ReciboNOV2018")]
        public string ReciboNov2018 { get; set; }
        [Column("FechaNOV2018", TypeName = "datetime")]
        public DateTime? FechaNov2018 { get; set; }
        [Column("MontoDIC2018", TypeName = "numeric(18, 2)")]
        public decimal? MontoDic2018 { get; set; }
        [Column("ReciboDIC2018")]
        public string ReciboDic2018 { get; set; }
        [Column("FechaDIC2018", TypeName = "datetime")]
        public DateTime? FechaDic2018 { get; set; }
        [Column("MontoENE2019", TypeName = "numeric(18, 2)")]
        public decimal? MontoEne2019 { get; set; }
        [Column("ReciboENE2019")]
        public string ReciboEne2019 { get; set; }
        [Column("FechaENE2019", TypeName = "datetime")]
        public DateTime? FechaEne2019 { get; set; }
        [Column("MontoFEB2019", TypeName = "numeric(18, 2)")]
        public decimal? MontoFeb2019 { get; set; }
        [Column("ReciboFEB2019")]
        public string ReciboFeb2019 { get; set; }
        [Column("FechaFEB2019", TypeName = "datetime")]
        public DateTime? FechaFeb2019 { get; set; }
        [Column("MontoMAR2019", TypeName = "numeric(18, 2)")]
        public decimal? MontoMar2019 { get; set; }
        [Column("ReciboMAR2019")]
        public string ReciboMar2019 { get; set; }
        [Column("FechaMAR2019", TypeName = "datetime")]
        public DateTime? FechaMar2019 { get; set; }
        [Column("MontoABR2019", TypeName = "numeric(18, 2)")]
        public decimal? MontoAbr2019 { get; set; }
        [Column("ReciboABR2019")]
        public string ReciboAbr2019 { get; set; }
        [Column("FechaABR2019", TypeName = "datetime")]
        public DateTime? FechaAbr2019 { get; set; }
        [Column("MontoMAY2019", TypeName = "numeric(18, 2)")]
        public decimal? MontoMay2019 { get; set; }
        [Column("ReciboMAY2019")]
        public string ReciboMay2019 { get; set; }
        [Column("FechaMAY2019", TypeName = "datetime")]
        public DateTime? FechaMay2019 { get; set; }
        [Column("MontoJUN2019", TypeName = "numeric(18, 2)")]
        public decimal? MontoJun2019 { get; set; }
        [Column("ReciboJUN2019")]
        public string ReciboJun2019 { get; set; }
        [Column("FechaJUN2019", TypeName = "datetime")]
        public DateTime? FechaJun2019 { get; set; }
        [Column("MontoJUL2019", TypeName = "numeric(18, 2)")]
        public decimal? MontoJul2019 { get; set; }
        [Column("ReciboJUL2019")]
        public string ReciboJul2019 { get; set; }
        [Column("FechaJUL2019", TypeName = "datetime")]
        public DateTime? FechaJul2019 { get; set; }
        [Column("MontoAGO2019", TypeName = "numeric(18, 2)")]
        public decimal? MontoAgo2019 { get; set; }
        [Column("ReciboAGO2019")]
        public string ReciboAgo2019 { get; set; }
        [Column("FechaAGO2019", TypeName = "datetime")]
        public DateTime? FechaAgo2019 { get; set; }
        [Column("MontoSEP2019", TypeName = "numeric(18, 2)")]
        public decimal? MontoSep2019 { get; set; }
        [Column("ReciboSEP2019")]
        public string ReciboSep2019 { get; set; }
        [Column("FechaSEP2019", TypeName = "datetime")]
        public DateTime? FechaSep2019 { get; set; }
        [Column("MontoOCT2019")]
        public string MontoOct2019 { get; set; }
        [Column("ReciboOCT2019")]
        public string ReciboOct2019 { get; set; }
        [Column("FechaOCT2019", TypeName = "datetime")]
        public DateTime? FechaOct2019 { get; set; }
        [Column("MontoNOV2019", TypeName = "numeric(18, 2)")]
        public decimal? MontoNov2019 { get; set; }
        [Column("ReciboNOV2019")]
        public string ReciboNov2019 { get; set; }
        [Column("FechaNOV2019", TypeName = "datetime")]
        public DateTime? FechaNov2019 { get; set; }
        [Column("MontoDIC2019", TypeName = "numeric(18, 2)")]
        public decimal? MontoDic2019 { get; set; }
        [Column("ReciboDIC2019")]
        public string ReciboDic2019 { get; set; }
        [Column("FechaDIC2019", TypeName = "datetime")]
        public DateTime? FechaDic2019 { get; set; }
    }
}
