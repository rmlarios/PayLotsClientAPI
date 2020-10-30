using Data.Model;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using NToastNotify;

namespace DevExtremeAspNetCoreResponsiveApp.Controllers
{
  public class BloquesController : GenericController<ViewConsolidadoBloques>
  {
    public BloquesController(IGenericProxy genericProxy, IToastNotification toastNotification) : base(genericProxy, toastNotification,"Bloque/","","GetbyUbicacion/")
    {
     
    }
  }
}