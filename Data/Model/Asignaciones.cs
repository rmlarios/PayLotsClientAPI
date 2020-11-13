using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Model
{
    public partial class Asignaciones
    {
        public Asignaciones()
        {
            Pagos = new HashSet<Pagos>();
        }

        public int IdAsignacion { get; set; }
        [Required(ErrorMessage="Debe seleccionar el lote.")]
        public int? IdLote { get; set; }
        [Required(ErrorMessage = "Debe seleccionar el beneficiario.")]
        public int? IdBeneficiario { get; set; }
        public DateTime? FechaInicioPago { get; set; }
        public int? DiaCuota { get; set; }
        [Required(ErrorMessage="Debe ingresar el costo del lote.")]
        [Range(1,100000,ErrorMessage="Valor debe mayor a 0.")]
        public decimal? MontoTotal { get; set; }
                
        [RequiredIf("AplicaInteres",false)]      
        public decimal? CuotaMinima { get; set; }
        public decimal? Prima { get; set; }
        public string Estado { get; set; }
        public bool? Donado { get; set; }
        public bool? AplicaInteres { get; set; }
        public decimal? TasaInteres { get; set; }
        public bool? AplicaMora { get; set; }
        public int? Plazo { get; set; }
        public string Observaciones { get; set; }
        public string Uar { get; set; }
        public DateTime Far { get; set; }
        public string Uua { get; set; }
        public DateTime Fua { get; set; }

        public virtual Beneficiarios IdBeneficiarioNavigation { get; set; }
        public virtual Lotes IdLoteNavigation { get; set; }
        public virtual ICollection<Pagos> Pagos { get; set; }
    }

    public class CustomRequiredAttribute : RequiredAttribute {  
    public CustomRequiredAttribute(string check) { }  
    //public CustomerType ConditionParameter { get; set; }  
    protected override ValidationResult IsValid(object value, ValidationContext validationContext) {  
        Asignaciones model = validationContext.ObjectInstance as Asignaciones;  
        if (model != null && model.AplicaInteres == false)  
            return ValidationResult.Success;  
        return base.IsValid(value, validationContext);  
    }  
    public override bool RequiresValidationContext {  
        get {  
            return true;  
        }  
    }  
}

public class RequiredIfAttribute : ValidationAttribute
{
    RequiredAttribute _innerAttribute = new RequiredAttribute();
    public string _dependentProperty { get; set; }
    public object _targetValue { get; set; }

    public RequiredIfAttribute(string dependentProperty, object targetValue)
    {
        this._dependentProperty = dependentProperty;
        this._targetValue = targetValue;
    }
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var field = validationContext.ObjectType.GetProperty(_dependentProperty);
        if (field != null)
        {
            var dependentValue = field.GetValue(validationContext.ObjectInstance, null);
            if ((dependentValue == null && _targetValue == null) || (dependentValue.Equals(_targetValue)))
            {
                if (!_innerAttribute.IsValid(value))
                {
                    string name = validationContext.DisplayName;
                    return new ValidationResult(ErrorMessage=name + " Is required.");
                }
            }
            return ValidationResult.Success;
        }
        else
        {
            return new ValidationResult(FormatErrorMessage(_dependentProperty));
        }
    }
}

}
