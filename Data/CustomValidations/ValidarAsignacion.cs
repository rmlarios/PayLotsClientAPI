using System;
using System.Collections.Generic;
using Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace Data.CustomValidations
{

[Route("[controller]/[action]")]
  public class ValidarAsignacion : Controller
  {
    public class Stuff
    {
      public List<Asignaciones> Items { get; set; }
    }
    [AcceptVerbs("GET", "POST")]
    public IActionResult EvalCuota(bool? AplicaInteres,decimal cuotaminima)
    {
      if(AplicaInteres==false && (cuotaminima<=0))
        return Json("Debe ingresar el monto de la cuota.");

      return Json(true);
    }

    [AcceptVerbs("GET","POST")]
    public IActionResult EvalTasa(bool AplicaInteres,decimal TasaInteres)
    {
        if((TasaInteres<=0))
        return Json("Debe ingresar la tasa de interés a aplicar.");

      return Json(true);
    }

    [AcceptVerbs("GET", "POST")]
     public IActionResult EvalPlazo(decimal? plazo,bool? aplicainteres)
    {
        if(aplicainteres==true && (plazo==null || plazo<=0))
        return Json("Debe ingresar el Plazo de la asignación.");

      return Json(true);
    }  

  }
}