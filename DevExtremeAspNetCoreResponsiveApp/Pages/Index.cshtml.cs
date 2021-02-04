using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Model;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DevExtremeAspNetCoreResponsiveApp.Pages
{
    public class IndexModel : PageModel
    {
        private IGenericProxy _genericProxy;
        public IndexModel(IGenericProxy genericProxy)
        {
            _genericProxy = genericProxy;
        }

        [BindProperty]
        public ViewDashboard dashboard { get; set; } = new ViewDashboard();
        public async Task OnGet()
        {
            var result = await _genericProxy.GetAsync<ViewDashboard>("DashBoard/Listar");
            if (result.Succeeded)
                dashboard = result.Datas[0];
            else
                dashboard = new ViewDashboard();
        }

        public async Task<IActionResult> OnGetSeguimientos(DataSourceLoadOptions options)
        {

            //JsonResult result = await OnGetBeneficiarios(options);
            var result = await _genericProxy.GetAsync<Seguimientos>("DashBoard/GetSeguimientos");
            /*if (result.Succeeded)
                dashboard = result.Datas[0];
            else
                dashboard = new ViewDashboard();*/

            return new JsonResult(DataSourceLoader.Load(result.Datas, options));
            //object obj = await beneficiariosController.Get(options);
            ///JsonResult result = new JsonResult(obj);
            //return result;
        }
    }
}
