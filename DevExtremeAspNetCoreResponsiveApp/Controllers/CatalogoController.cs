using System;
using System.Threading.Tasks;
using Data.Model;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DevExtremeAspNetCoreResponsiveApp.Controllers
{
    public class CatalogoController:ControllerBase
    {        
        private readonly IGenericProxy _genericProxy;
        public CatalogoController(IGenericProxy genericProxy)
        {
            _genericProxy = genericProxy;
        }

        [HttpGet("Municipios")]
        public async Task<IActionResult> Municipios()
        {
            var result = await _genericProxy.GetAsync<ViewDepartamentosMunicipios>("Municipios/Listar");
            return Content(JsonConvert.SerializeObject(result.Datas));
        }
    }
}
