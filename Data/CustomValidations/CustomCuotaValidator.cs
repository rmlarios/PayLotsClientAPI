using System;
using System.ComponentModel.DataAnnotations;
using Data.Model;

namespace Data.CustomValidations
{
  public class CustomCuotaValidator : ValidationAttribute
  {
    public CustomCuotaValidator()
    {

    }

    protected override ValidationResult IsValid(object value,
   ValidationContext validationContext)
    {
      var asignaciones = (Asignaciones)validationContext.ObjectInstance;
      if (asignaciones.AplicaInteres == null || asignaciones.AplicaInteres == false)
      {
        if ((asignaciones.CuotaMinima == null || asignaciones.CuotaMinima <= 0) && validationContext.DisplayName=="CuotaMinima")
          return new ValidationResult("Debe ingresar el valor de la cuota.");
      }else if(asignaciones.AplicaInteres==true){
        if((asignaciones.TasaInteres==null || asignaciones.TasaInteres<=0 || asignaciones.Plazo==null || asignaciones.Plazo<=0) && (validationContext.DisplayName=="TasaInteres" || validationContext.DisplayName=="Plazo"))
          return new ValidationResult("Debe ingresar el campo " + validationContext.DisplayName);
      }



      return ValidationResult.Success;
    }
  }
}

