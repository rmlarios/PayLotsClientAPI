using Data.Model;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using NToastNotify;

namespace DevExtremeAspNetCoreResponsiveApp.Controllers
{
  public class AsignacionesController : GenericController<ViewAsignacionesLotes>
  {
    public AsignacionesController(IGenericProxy genericProxy, IToastNotification toastNotification) : base(genericProxy, toastNotification, "Asignacion/", "GetAsignaciones", "GetbyBenef/")
    {
    }
  }
}