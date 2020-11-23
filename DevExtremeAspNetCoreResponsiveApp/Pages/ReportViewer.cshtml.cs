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

namespace DevExtremeAspNetCoreResponsiveApp.Pages
{
    public class ReportViewerModel : PageModel
    {
        private readonly IGenericProxy _genericproxy;
        public ReportViewerModel(IGenericProxy genericProxy)
        {
            _genericproxy = genericProxy;
        }

        [BindProperty]
        public string reporte { get; set; }

        public XtraReport Report { get; set; }


        public async Task OnGet(int? p)
        {
            switch (TempData["ReportName"])
            {
                case "PlandePago":
                    Report = new RptPlandePago();
                    var source = await _genericproxy.GetAsync<Asignacion_PlandePago>("Pago/GetPlanPago/"+p);
                    Report.DataSource = source.Datas;
                    Report.DataMember = Report.DataMember;
                    break;
            }


        }
    }
}
