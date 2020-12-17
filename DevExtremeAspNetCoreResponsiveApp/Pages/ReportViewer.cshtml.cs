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
using System.Drawing;

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
            var path = Path.Combine(_env.ContentRootPath, "Reports");
            switch (r)
            {
                case "pp"://Plan de Pago
                    Report = new RptPlandePago();
                    var source = await _genericproxy.GetAsync<Asignacion_PlandePago>("Pago/GetPlanPago/"+p);
                    //var path = Path.Combine(_env.ContentRootPath, "Reports");
                    Report.LoadLayout(path + "\\RptPlandePago.repx");
                    CargarDatosEmpresa(Report);
                    Report.DataSource = source.Datas;
                    Report.DataMember = Report.DataMember;
                    break;
                case "pf"://Pago por fechas
                    Report = new RptPagosFechas();
                    var source2 = await _genericproxy.GetAsync<ViewPagosAsignaciones>("Pago/GetListado?vigentes=" + false);
                    //var path2 = Path.Combine(_env.ContentRootPath, "Reports");
                    Report.LoadLayout(path + "\\RptPagosFechas.repx");
                    CargarDatosEmpresa(Report);
                    Report.DataSource = source2.Datas.Where(m=>m.FechaRecibo>=Convert.ToDateTime("01/08/2020"));
                    Report.DataMember = Report.DataMember;
                    break;
                case "pro"://Proforma
                    Report = new RptProforma();
                    var source3 = await _genericproxy.GetAsync<Proformas>("Proforma/GetProforma/" + p);
                    Report.LoadLayout(path + "\\RptProforma.repx");
                    CargarDatosEmpresa(Report);
                    Report.DataSource = source3.Datas;
                    Report.DataMember = Report.DataMember;
                    break;
            }


        }

        public async Task CargarDatosEmpresa(XtraReport Reporte)
        {
            /*Cargamos los datos de la empresa*/
            var result = await _genericproxy.GetAsync<DatosEmpresa>("DatosEmpresa/Listar");
            Reporte.FindControl("lblNombreEmpresa", true).Text = result.Datas[0].NombreEmpresa;
            Reporte.FindControl("lblDireccion", true).Text = result.Datas[0].Direccion;
            Reporte.FindControl("lblTelefono", true).Text = result.Datas[0].Telefono;
            if (result.Datas[0].Logo != null)
                ((XRPictureBox)Reporte.FindControl("picLogo", true)).Image = Image.FromStream(new MemoryStream(result.Datas[0].Logo));
            /**********************************/
        }


    }
}
