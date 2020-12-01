using Data.Model;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.CustomValidations
{
    class CustomTasaCambioValidator : ValidationAttribute, IClientModelValidator
    {
        public CustomTasaCambioValidator()
        {

        }

        protected override ValidationResult IsValid(object value,ValidationContext validationContext)
        {
            var pago = (ViewPagosAsignaciones)validationContext.ObjectInstance;
            if(pago.Moneda == "Córdobas" && (pago.TasaCambio==0 || pago.TasaCambio == null))
            {
                return new ValidationResult("Debe de ingresar la Tasa de Cambio.");
            }            

            return ValidationResult.Success;
        }

        public void AddValidation(ClientModelValidationContext context)
        {
            string att = context.ModelMetadata.GetDisplayName();
            context.Attributes.Add("data-val-custom-tasacambiovalidator", "Debe ingresar la Tasa de Cambio.");
            context.Attributes.Add(
                "data-val-custom-tasacambiovalidator-validationcallback",
                $@"function(options) {{                  
                  var field = options.formItem.dataField;
                  var moneda= vform.getEditor(""Moneda"").option(""value"");                  
                  var tasa = vform.getEditor(""TasaCambio"").option(""value"");                  
                
                  if(moneda==""Córdobas"" && (tasa==0 || tasa==null))
                  {{                  
                      return false;                                 
                  }}
                  
                  
                  return true;
                }}");
        }
    }
}
