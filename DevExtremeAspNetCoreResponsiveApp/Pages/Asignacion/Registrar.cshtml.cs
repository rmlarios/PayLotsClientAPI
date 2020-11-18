using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Model;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NToastNotify;

namespace DevExtremeAspNetCoreResponsiveApp.Pages.Asignacion
{
  public class RegistrarModel : PageModel
  {
    private IGenericProxy _genericProxy;
    private readonly IToastNotification _toastNotification;
    [BindProperty]
    public Asignaciones Asignaciones { get; set; }
    public RegistrarModel(IGenericProxy genericProxy, IToastNotification toastNotification)
    {
      _genericProxy = genericProxy;
      _toastNotification = toastNotification;
    }
    public async Task OnGet(int p = 0)
    {

      if (p == 0)
        Asignaciones = new Asignaciones();
      else
      {
        var result = await _genericProxy.GetAsync<Asignaciones>("Asignacion/GetDatosbyId/" + p);
        if (result.Succeeded)
          Asignaciones = result.Datas[0];
        else
          Asignaciones = new Asignaciones();
      }
    }

    public async Task OnPost([FromForm] int IdAsignacion, [FromForm] Asignaciones entity)
    {

      if (!ModelState.IsValid)
      {
        var Errors = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).Aggregate((U, V) => U + "," + V);
        _toastNotification.AddErrorToastMessage(Errors);
        ModelState.AddModelError("custom", Errors);
        return;
      }

      var result = await _genericProxy.PostAsync<Asignaciones>("Asignacion/Save/" + IdAsignacion, entity);
      if (result.Succeeded)
      {
        _toastNotification.AddSuccessToastMessage(result.Message);
        IdAsignacion = result.Data.IdAsignacion;
        //return Page();
        //return LocalRedirect(Url.Page("/Asignacion/Registrar?p=" + IdAsignacion));
        //RedirectToPage(Url.Page("/Asignacion/Registrar?p=" + IdAsignacion));
        //return new OkObjectResult(result.Message);
        //await OnGet(IdAsignacion);
        Response.Redirect("/Asignacion/Registrar/?p=" + IdAsignacion);
      }
      else
      {
        _toastNotification.AddErrorToastMessage(result.Message);
        return;
        //return BadRequest(result.Message);
      }

      await OnGet(IdAsignacion);
      //return RedirectToPage();


    }
  }
}