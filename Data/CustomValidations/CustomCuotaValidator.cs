using System;
using System.ComponentModel.DataAnnotations;
using Data.Model;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Data.CustomValidations
{
  public class CustomCuotaValidator : ValidationAttribute, IClientModelValidator
  {
    public CustomCuotaValidator()
    {

    }

     public string GetErrorMessage(string field) =>
        $"Debe ingresar el valor de la " + field;

    protected override ValidationResult IsValid(object value,
   ValidationContext validationContext)
    {
      var asignaciones = (Asignaciones)validationContext.ObjectInstance;
      if (asignaciones.AplicaInteres == null || asignaciones.AplicaInteres == false)
      {
        if ((asignaciones.CuotaMinima == null || asignaciones.CuotaMinima <= 0) && validationContext.DisplayName == "CuotaMinima")
          return new ValidationResult(GetErrorMessage(validationContext.DisplayName));
      }
      else if (asignaciones.AplicaInteres == true)
      {
        if ((asignaciones.TasaInteres == null || asignaciones.TasaInteres <= 0 || asignaciones.Plazo == null || asignaciones.Plazo <= 0) && (validationContext.DisplayName == "TasaInteres" || validationContext.DisplayName == "Plazo"))
          return new ValidationResult("Debe ingresar el campo " + validationContext.DisplayName);
      }

      return ValidationResult.Success;
    }

     void IClientModelValidator.AddValidation(ClientModelValidationContext context) {
      string att = context.ModelMetadata.GetDisplayName();
      context.Attributes.Add("data-val-custom-"+ att +"validator", GetErrorMessage(context.ModelMetadata.GetDisplayName()));
            context.Attributes.Add(
                "data-val-custom-"+att+"validator-validationcallback",
                $@"function(options) {{                  
                  var field = options.formItem.dataField;
                  var ai= vform.getEditor(""AplicaInteres"").option(""value"");
                  var cuota = vform.getEditor(""CuotaMinima"").option(""value"");
                  var tasa = vform.getEditor(""TasaInteres"").option(""value"");
                  var plazo = vform.getEditor(""Plazo"").option(""value"");
                  
                  if(ai==null || ai==false)
                  {{
                    if((cuota==null || cuota<=0) && field == ""CuotaMinima"")
                      return false;
                    else                   
                        return true;                    
                  }}
                  else
                  {{
                    if((field==""TasaInteres""))
                        if(tasa==null || tasa <=0)
                          return false;
                        else
                          return true;
                    else if(field==""Plazo"")
                        if(plazo==null || plazo<=0)
                          return false;
                        else
                          return true;
                    else
                        return true;
                  }} 
                  
                  return true;
                }}");
        }
  } 
  }


