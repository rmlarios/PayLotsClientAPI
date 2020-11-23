using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Data.CustomValidations;
//using Microsoft.AspNetCore.Mvc;

namespace Data.Model
{
  public partial class Asignaciones
  {
    public Asignaciones()
    {
      Pagos = new HashSet<Pagos>();
    }

    public int IdAsignacion { get; set; }
    [Required(ErrorMessage = "Debe seleccionar el lote.")]
    public int? IdLote { get; set; }
    [Required(ErrorMessage = "Debe seleccionar el beneficiario.")]
    public int? IdBeneficiario { get; set; }
    [Required(ErrorMessage = "Debe ingresar la fecha de inicio de pago.")]
    [DataType(DataType.DateTime)]    
    public DateTime? FechaInicioPago { get; set; }
    public int? DiaCuota { get; set; }
    [Required(ErrorMessage = "Debe ingresar el costo del lote.")]
    [Range(1, 100000, ErrorMessage = "Valor debe mayor a 0.")]
    public decimal? MontoTotal { get; set; } = 0;
    [CustomCuotaValidator]
    public decimal? CuotaMinima { get; set; } = 0;
    [Range(0, 100000)]
    public decimal? Prima { get; set; } = 0;
    public string Estado { get; set; }
    public bool? Donado { get; set; } = false;
    public bool? AplicaInteres { get; set; } = false;
    [CustomCuotaValidator]
    public decimal? TasaInteres { get; set; } = 0;
    public bool? AplicaMora { get; set; } = false;

    [CustomCuotaValidator]
    public int? Plazo { get; set; } = 0;
    public string Observaciones { get; set; } = string.Empty;
    public string Uar { get; set; }
    public DateTime Far { get; set; }
    public string Uua { get; set; }
    public DateTime Fua { get; set; }

    public virtual Beneficiarios IdBeneficiarioNavigation { get; set; }
    public virtual Lotes IdLoteNavigation { get; set; }
    public virtual ICollection<Pagos> Pagos { get; set; }
  }


  public class CustomRequiredAttribute : RequiredAttribute
  {
    public CustomRequiredAttribute(string check) { }
    //public CustomerType ConditionParameter { get; set; }  
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
      Asignaciones model = validationContext.ObjectInstance as Asignaciones;
      if (model != null && model.AplicaInteres == false)
        return ValidationResult.Success;
      return base.IsValid(value, validationContext);
    }
    public override bool RequiresValidationContext
    {
      get
      {
        return true;
      }
    }
  }
}
