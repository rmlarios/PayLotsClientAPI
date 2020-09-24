using System.Net.Cache;
using System.Threading.Tasks;
using DevExtremeAspNetCoreResponsiveApp.Model;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DevExtremeAspNetCoreResponsiveApp.Pages.ListaBeneficiarios
{
  public class ListadoBeneficiarioModel : PageModel
  {
    private readonly IGenericProxy _proxy;
    public ListadoBeneficiarioModel(IGenericProxy proxy)
    {
        _proxy = proxy;
    }

    [HttpGet]
    public async Task OnGetBeneficiarios()
    {
      var result = await _proxy.GetAsync<Beneficiarios>("Beneficiario/Listar");           
    }

  }
}