using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Model;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using NToastNotify;

namespace DevExtremeAspNetCoreResponsiveApp.Pages.Ubicacion
{
  public class ListadoModel : PageModel
  {
    private readonly IGenericProxy _genericProxy;
    private readonly IToastNotification _toastNotification;
    [TempData]
    public string Mensaje { get; set; }
    public ListadoModel(IGenericProxy genericProxy, IToastNotification toastNotification)
    {
      _genericProxy = genericProxy;
      _toastNotification = toastNotification;
    }

    public void OnGet()
    {
      _toastNotification.AddInfoToastMessage("Info");
    }

    public async Task<IActionResult> OnGetListado(DataSourceLoadOptions loadOptions)
    {
      var result = await _genericProxy.GetAsync<ViewConsolidadoUbicaciones>("Ubicacion/GetUbicaciones");
      return new JsonResult(DataSourceLoader.Load(result.Datas, loadOptions));
    }

    public async Task<IActionResult> OnGetBloques(int id, DataSourceLoadOptions loadOptions)
    {
      var result = await _genericProxy.GetAsync<ViewConsolidadoBloques>("Bloque/GetbyUbicacion/" + id);
      return new JsonResult(DataSourceLoader.Load(result.Datas, loadOptions));
    }


    public async Task<IActionResult> OnPostCreateBloque([FromForm] string values)
    {
      Bloques bloque = new Bloques();
      JsonConvert.PopulateObject(values, bloque);
      var result = await _genericProxy.PostAsync<Bloques>("Bloque/Create", bloque);
      if (result.Succeeded)
        return new OkObjectResult(result.Message);
      else
        return BadRequest(result.Message);

      /* await OnGetListado(new DataSourceLoadOptions);

      return Page(); */
      //return RedirectToPage("Listado");

    }
  }
}