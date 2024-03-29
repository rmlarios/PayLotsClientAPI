using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Model;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using DevExtremeAspNetCoreResponsiveApp.DTOs;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using DevExtremeAspNetCoreResponsiveApp.Proxies.Models;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace DevExtremeAspNetCoreResponsiveApp.Controllers
{
  public class PagosController : GenericController<Pagos>
  {
    private readonly IGenericProxy _proxy;
    public PagosController(IGenericProxy genericProxy, IToastNotification toastNotification) : base(genericProxy, toastNotification, "Pago", "GetAllUrl", "GetbyIdUrl")
    {
      _proxy = genericProxy;
    }

    
    [HttpGet("GetPlan")]    
    public async Task<IActionResult> GetPlan(int idasignacion,DataSourceLoadOptions loadOptions)
    {
      if (idasignacion != 0)
      {
        var result = await _proxy.GetAsync<Asignacion_PlandePago>("Pago/GetPlanPago/" + idasignacion);
        return new JsonResult(DataSourceLoader.Load(result.Datas, loadOptions));
      }
      else
      {
        List<Asignacion_PlandePago> empty = new List<Asignacion_PlandePago>();
        var result = new Response<Asignacion_PlandePago>(empty);
        return new JsonResult(DataSourceLoader.Load(result.Datas, loadOptions));
      }
    }



  }
}