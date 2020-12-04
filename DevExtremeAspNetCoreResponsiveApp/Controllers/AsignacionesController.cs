using System.Threading.Tasks;
using Data.Model;
using DevExtremeAspNetCoreResponsiveApp.DTOs;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NToastNotify;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace DevExtremeAspNetCoreResponsiveApp.Controllers
{
  public class AsignacionesController : GenericController<ViewAsignacionesLotes>
  {
    IToastNotification _toastNotification;

    public AsignacionesController(IGenericProxy genericProxy, IToastNotification toastNotification) : base(genericProxy, toastNotification, "Asignacion/", "GetAsignaciones", "GetbyBenef/")
    {
      _toastNotification = toastNotification;
    }

    [HttpPost]
    public async Task<IActionResult> Anular([FromForm] AnularAsignacionRequest values)
    {
      string url = Request.GetTypedHeaders().Referer.ToString();

      //JsonConvert.PopulateObject(values, entity);
      var result = await _genericProxy.PostAsync<AnularAsignacionRequest>("Asignacion/Anular", values);
      if (result.Succeeded)
      {
        _toastNotification.AddSuccessToastMessage(result.Message);
        //TempData["Msg"] = "Uploaded successfully";        
        //return new OkObjectResult(result.Message);
      }
      else
      {
        _toastNotification.AddErrorToastMessage(result.Message);
        //TempData["Msg"] = "Uploaded error"; 
        //return BadRequest(result.Message);
      }
      return Redirect(url);
      //return LocalRedirect("~/Asignacion/Listado");
      //return View();
    }

  }
}