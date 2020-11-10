using System;
using Data.Model;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using NToastNotify;

namespace DevExtremeAspNetCoreResponsiveApp.Controllers
{
  public class LotesController : GenericController<ViewLotes>
  {
    public LotesController(IGenericProxy genericProxy, IToastNotification toastNotification) : base(genericProxy, toastNotification, "Lote/", "GetLotes", "")
    {
    }
  }
}
