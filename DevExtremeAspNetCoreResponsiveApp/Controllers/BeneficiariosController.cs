using Data.Model;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NToastNotify;
using System.Collections.Generic;
using System.Net.Http;
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

        [HttpGet("ListarBenef")]
        public async Task<IActionResult> GetAllBenef(DataSourceLoadOptions loadOptions)
        {
            //loadOptions.RequireTotalCount = true;
            
            var result = await _genericProxy.GetAsync<Beneficiarios>("Beneficiario/Listar");
            LoadResult newresult = new LoadResult();
            newresult.totalCount = 100;
            newresult.data = result.Datas;
            //return new JsonResult(DataSourceLoader.Load(result.Datas, loadOptions)); ;
            return new OkObjectResult(newresult);
        }
    }
}