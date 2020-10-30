using Data.Model;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using NToastNotify;

namespace DevExtremeAspNetCoreResponsiveApp.Controllers
{
  public class UbicacionesController : GenericController<ViewConsolidadoUbicaciones>
  {
    public UbicacionesController(IGenericProxy genericProxy, IToastNotification toastNotification) : base(genericProxy, toastNotification,"Ubicacion/","GetUbicaciones/","")
    {
     
    }
  }
}