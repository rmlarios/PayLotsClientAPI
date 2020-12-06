using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtremeAspNetCoreResponsiveApp.DTOs;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using DevExtremeAspNetCoreResponsiveApp.Reports;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NToastNotify;

namespace DevExtremeAspNetCoreResponsiveApp.Pages.Reportes
{
    public class EstadoCuentaModel : PageModel
    {
        private readonly IGenericProxy _genericProxy;
        private readonly IToastNotification _toastNotification;
        public EstadoCuentaModel(IGenericProxy genericProxy, IToastNotification toastNotification)
        {
            _genericProxy = genericProxy;
            _toastNotification = toastNotification;
        }
        public RptEstadoCuenta rptEstadoCuenta { get; set; } = new RptEstadoCuenta();
        public async Task OnGet(int? id)
        {
            if (id != null)
            {
                //rptEstadoCuenta = new RptEstadoCuenta();
                var source = await _genericProxy.GetAsync<EstadoCuenta>("Asignacion/GetEstadoCuenta/" + id);
                rptEstadoCuenta.DataSource = source.Datas;
                rptEstadoCuenta.DataMember = rptEstadoCuenta.DataMember;
            }
        }
    }
}
