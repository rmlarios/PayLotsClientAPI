using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Data.Model;

namespace DevExtremeAspNetCoreResponsiveApp.Pages.Beneficiario
{
  public class ListadoModel : PageModel
  {
    [BindProperty]
    public string NombreActual { get; set; } = "";
    private readonly IGenericProxy _proxy;

    public ListadoModel(IGenericProxy proxy)
    {
      _proxy = proxy;
    }
    public async Task<IActionResult> OnGetListado()
    {
      var result = await _proxy.GetAsync<Beneficiarios>("Beneficiario/Listar");
      return Content(JsonConvert.SerializeObject(result.Datas), "application/json");
    }

    public async Task<IActionResult> OnGetAsignaciones(int id)
    {
      var result = await _proxy.GetAsync<ViewAsignacionesLotes>("Asignacion/GetbyBenef/" + id);
      return Content(JsonConvert.SerializeObject(result.Datas), "application/json");
    }
  }
}