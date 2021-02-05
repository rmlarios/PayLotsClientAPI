using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Data.Model;
using DevExpress.XtraReports.UI;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using DevExtremeAspNetCoreResponsiveApp.Reports;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DevExtremeAspNetCoreResponsiveApp.Pages.Reportes
{
    public class PagosporFechasModel : PageModel
    {
        private readonly IGenericProxy _genericProxy;
        private readonly IHostingEnvironment _env;
        public RptPagosFechas rptFechas { get; set; } = new RptPagosFechas();
        public PagosporFechasModel(IGenericProxy genericProxy, IHostingEnvironment env)
        {
            _genericProxy = genericProxy;
            _env = env;
        }
        public async Task OnGet(string d="",string h="")
        {
            if(d==""&& h == "")
            {
                return;
            }
            var source = await _genericProxy.GetAsync<ViewPagosAsignaciones>("Pago/GetListado?vigentes=" + false);
            var data  = source.Datas.Where(m => m.FechaRecibo != null);
            var path = Path.Combine(_env.ContentRootPath, "Reports");
            rptFechas.LoadLayout(path + "\\RptPagosFechas.repx");
            CargarDatosEmpresa(rptFechas);
            if(d!=""&&h!="")
                rptFechas.DataSource = data.Where(m => m.FechaRecibo >= Convert.ToDateTime(d) && m.FechaRecibo<=Convert.ToDateTime(h));
            else if(d!=""&&h=="")
                rptFechas.DataSource = data.Where(m => m.FechaRecibo.Value.Date == Convert.ToDateTime(d).Date);
            rptFechas.DataMember = rptFechas.DataMember;
        }

        public async Task CargarDatosEmpresa(XtraReport Reporte)
        {
            /*Cargamos los datos de la empresa*/
            var result = await _genericProxy.GetAsync<DatosEmpresa>("DatosEmpresa/Listar");
            Reporte.FindControl("lblNombreEmpresa", true).Text = result.Datas[0].NombreEmpresa;
            Reporte.FindControl("lblDireccion", true).Text = result.Datas[0].Direccion;
            Reporte.FindControl("lblTelefono", true).Text = result.Datas[0].Telefono;
            if (result.Datas[0].Logo != null)
                ((XRPictureBox)Reporte.FindControl("picLogo", true)).Image = Image.FromStream(new MemoryStream(result.Datas[0].Logo));
            /**********************************/
        }
    }
}
