using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtremeAspNetCoreResponsiveApp.Model;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace DevExtremeAspNetCoreResponsiveApp.Pages.Beneficiario
{
    public class ListadoModel : PageModel
    {
        private readonly IGenericProxy _proxy;
        public ListadoModel(IGenericProxy proxy)
        {
            _proxy=proxy;
        }
        public async Task<IActionResult> OnGetListado()
        {
            var result = await _proxy.GetAsync<Beneficiarios>("Beneficiario/Listar");           
            return Content(JsonConvert.SerializeObject(result.Datas), "application/json");
        }
    }
}