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
using Data.Model;
using DevExpress.XtraReports.UI;
using System.Drawing;

namespace DevExtremeAspNetCoreResponsiveApp.Pages.Reportes
{
    public class EstadoCuentaModel : PageModel
    {
        private readonly IGenericProxy _genericProxy;
        private readonly IToastNotification _toastNotification;
        private readonly IHostingEnvironment _env;

        [BindProperty]
        public int idselected { get; set; }
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
                idselected = Convert.ToInt32(id);
                var source = await _genericProxy.GetAsync<EstadoCuenta>("Asignacion/GetEstadoCuenta/" + id);               
                var path = Path.Combine(_env.ContentRootPath, "Reports");                
                rptEstadoCuenta.LoadLayout(path+"\\RptEstadoCuenta.repx");
                CargarDatosEmpresa(rptEstadoCuenta);
                rptEstadoCuenta.DataSource = source.Datas;
                rptEstadoCuenta.DataMember = rptEstadoCuenta.DataMember;
            }
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
