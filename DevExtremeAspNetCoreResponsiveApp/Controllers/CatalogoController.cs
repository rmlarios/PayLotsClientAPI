using System;
using System.Threading.Tasks;
using Data.Model;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NToastNotify;

namespace DevExtremeAspNetCoreResponsiveApp.Controllers
{
    public class CatalogoController:GenericController<ViewDepartamentosMunicipios>
    {        
       
        public CatalogoController(IGenericProxy genericProxy, IToastNotification toastNotification):base(genericProxy,toastNotification,"Municipios/","Listar","")
        {
         
        }

        /* [HttpGet("Municipios")]
        public async Task<IActionResult> Municipios()
        {
            var result = await _genericProxy.GetAsync<ViewDepartamentosMunicipios>("Municipios/Listar");
            return Content(JsonConvert.SerializeObject(result.Datas));
        } */
    }
}
