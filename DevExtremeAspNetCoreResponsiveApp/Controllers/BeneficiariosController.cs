using Data.Model;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NToastNotify;
using System.Threading.Tasks;

namespace DevExtremeAspNetCoreResponsiveApp.Controllers
{
  public class BeneficiariosController : GenericController<Beneficiarios>
  {
        private readonly IToastNotification _toastNotification;
    public BeneficiariosController(IGenericProxy genericProxy, IToastNotification toastNotification) : base(genericProxy, toastNotification, "Beneficiario/", "Listar", "")
    {
            _toastNotification = toastNotification;
    }

        [HttpPost("PostCrearBenef")]
        public async Task<IActionResult> PostCrearBenef([FromBody]Beneficiarios values)
        {
            //    Beneficiarios entity = new Beneficiarios();
            //  JsonConvert.PopulateObject(values, entity);
            var result = await _genericProxy.PostAsync<Beneficiarios>("Beneficiario/Create", values);
            if (result.Succeeded)
            {
                //  _toastNotification.AddSuccessToastMessage(result.Message);
                return Ok(result.Data.IdBeneficiario);
                //return new OkObjectResult(result.Message);
            }
            else
            {
                _toastNotification.AddErrorToastMessage(result.Message);
                return BadRequest(error: result.Message);
            }
        }
    }
}