using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DevExtremeAspNetCoreResponsiveApp.DTOs;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using DevExtremeAspNetCoreResponsiveApp.Reports;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NToastNotify;
using Microsoft.AspNetCore.Hosting;

namespace DevExtremeAspNetCoreResponsiveApp.Pages.Reportes
{
    public class EstadoCuentaModel : PageModel
    {
        private readonly IGenericProxy _genericProxy;
        private readonly IToastNotification _toastNotification;
        private readonly IHostingEnvironment _env;
        public EstadoCuentaModel(IGenericProxy genericProxy, IToastNotification toastNotification, IHostingEnvironment env)
        {
            _genericProxy = genericProxy;
            _toastNotification = toastNotification;
            _env = env;
        }
        public RptEstadoCuenta rptEstadoCuenta { get; set; } = new RptEstadoCuenta();
        public async Task OnGet(int? id)
        {
            if (id != null)
            {
                //rptEstadoCuenta = new RptEstadoCuenta();
                var source = await _genericProxy.GetAsync<EstadoCuenta>("Asignacion/GetEstadoCuenta/" + id);               
                var path = Path.Combine(_env.ContentRootPath, "Reports");                
                rptEstadoCuenta.LoadLayout(path+"\\RptEstadoCuenta.repx");
                rptEstadoCuenta.DataSource = source.Datas;
                rptEstadoCuenta.DataMember = rptEstadoCuenta.DataMember;
            }
        }
    }
}
