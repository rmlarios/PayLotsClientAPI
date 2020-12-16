using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Model;
using DevExpress.DataAccess.Json;
using DevExpress.XtraReports.UI;
using DevExtremeAspNetCoreResponsiveApp.DTOs;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using DevExtremeAspNetCoreResponsiveApp.Reports;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace DevExtremeAspNetCoreResponsiveApp.Pages
{
    public class ReportViewerModel : PageModel
    {
        private readonly IGenericProxy _genericproxy;
        private readonly IHostingEnvironment _env;
        public ReportViewerModel(IGenericProxy genericProxy,IHostingEnvironment env)
        {
            _genericproxy = genericProxy;
            _env = env;
        }

        [BindProperty]
        public string reporte { get; set; }

        public XtraReport Report { get; set; }


        public async Task OnGet(string? r,int? p)
        {
            switch (r)
            {
                case "pp"://Plan de Pago
                    Report = new RptPlandePago();
                    var source = await _genericproxy.GetAsync<Asignacion_PlandePago>("Pago/GetPlanPago/"+p);
                    var path = Path.Combine(_env.ContentRootPath, "Reports");
                    Report.LoadLayout(path + "\\RptPlandePago.repx");
                    Report.DataSource = source.Datas;
                    Report.DataMember = Report.DataMember;
                    break;
                case "pf"://Pago por fechas
                    Report = new RptPagosFechas();
                    var source2 = await _genericproxy.GetAsync<ViewPagosAsignaciones>("Pago/GetListado?vigentes=" + false);
                    var path2 = Path.Combine(_env.ContentRootPath, "Reports");
                    Report.LoadLayout(path2 + "\\RptPagosFechas.repx");
                    Report.DataSource = source2.Datas.Where(m=>m.FechaRecibo>=Convert.ToDateTime("01/08/2020"));
                    Report.DataMember = Report.DataMember;
                    break;
            }


        }
    }
}
