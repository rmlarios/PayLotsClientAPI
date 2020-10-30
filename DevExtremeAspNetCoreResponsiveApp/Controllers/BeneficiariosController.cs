using Data.Model;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using NToastNotify;

namespace DevExtremeAspNetCoreResponsiveApp.Controllers
{
  public class BeneficiariosController : GenericController<Beneficiarios>
  {
    public BeneficiariosController(IGenericProxy genericProxy, IToastNotification toastNotification) : base(genericProxy, toastNotification, "Beneficiario/", "Listar", "")
    {
    }
  }
}