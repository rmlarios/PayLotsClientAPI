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

        [BindProperty]
        public int idselected { get; set; }
        public DateTime desde { get; set; } = DateTime.Now;
        public DateTime? hasta { get; set; } = DateTime.Now;
        public async Task OnGet(string d="",string h="",string p="")
        {
            if(d==""&& h == "")
            {
                return;
            }
            //var source = await _genericProxy.GetAsync<ViewPagosAsignaciones>("Pago/GetListado?vigentes=" + false);
            //var data  = source.Datas.Where(m => m.FechaRecibo != null);
            string Urlquery = "";
            if (d != "" && h != "")
            {
                //data = data.Where(m => m.FechaRecibo >= Convert.ToDateTime(d) && m.FechaRecibo <= Convert.ToDateTime(h));
                Urlquery = "Desde=" + d + "&Hasta=" + h;
                desde = Convert.ToDateTime(d);
                hasta = Convert.ToDateTime(h);
                //rptFechas.DataSource = data.Where(m => m.FechaRecibo >= Convert.ToDateTime(d) && m.FechaRecibo<=Convert.ToDateTime(h));
            }
            else if (d != "" && h == "")
            {
                //data = data.Where(m => m.FechaRecibo.Value.Date == Convert.ToDateTime(d).Date);
                Urlquery = "Desde=" + d;
                desde = Convert.ToDateTime(d);
                hasta = null;
            }
            //rptFechas.DataSource = data.Where(m => m.FechaRecibo.Value.Date == Convert.ToDateTime(d).Date);
            if (p != "0")
            {
                //data = data.Where(m => m.IdUbicacion.ToString() == p);
                Urlquery = Urlquery + "&IdProyecto=" + p;
                idselected = Convert.ToInt32(p);
            }

            var data = await _genericProxy.GetAsync<ViewPagosAsignaciones>("Pago/GetPagosFechas?" + Urlquery);
            var path = Path.Combine(_env.ContentRootPath, "Reports");
            rptFechas.LoadLayout(path + "\\RptPagosFechas.repx");
            CargarDatosEmpresa(rptFechas);

            rptFechas.DataSource = data.Datas;
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
