using System.ComponentModel.DataAnnotations;

namespace DevExtremeAspNetCoreResponsiveApp.DTOs
{
    public class AnularAsignacionRequest
    {
        public int? IdAsignacion { get; set; }
        [Required(ErrorMessage="Debe ingresar el motivo de la anulación.")]
        public string Observaciones { get; set; }
    }
}