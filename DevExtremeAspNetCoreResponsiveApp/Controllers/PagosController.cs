using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Data.Model;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using DevExtremeAspNetCoreResponsiveApp.DTOs;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using DevExtremeAspNetCoreResponsiveApp.Proxies.Models;
using DevExtremeAspNetCoreResponsiveApp.Reports;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using Microsoft.AspNetCore.Hosting;

namespace DevExtremeAspNetCoreResponsiveApp.Controllers
{
    public class PagosController : GenericController<ViewPagosAsignaciones>
    {
        private readonly IHostingEnvironment _env;
        //private readonly IGenericProxy _proxy;
        public PagosController(IGenericProxy genericProxy, IToastNotification toastNotification,IHostingEnvironment env) : base(genericProxy, toastNotification, "Pago/", "GetListado?vigentes=" + true, "GetByAsignacion/")
        {
            //_proxy = genericProxy;
            _env = env;
        }


        [HttpGet("GetPlan")]
        public async Task<IActionResult> GetPlan(int idasignacion, DataSourceLoadOptions loadOptions)
        {
            if (idasignacion != 0)
            {
                var result = await _genericProxy.GetAsync<Asignacion_PlandePago>("Pago/GetPlanPago/" + idasignacion);
                return new JsonResult(DataSourceLoader.Load(result.Datas, loadOptions));
            }
            else
            {
                List<Asignacion_PlandePago> empty = new List<Asignacion_PlandePago>();
                var result = new Response<Asignacion_PlandePago>(empty);
                return new JsonResult(DataSourceLoader.Load(result.Datas, loadOptions));
            }
        }

        [HttpGet("GetMeses")]
        public async Task<IActionResult> GetMeses(int idasignacion, DataSourceLoadOptions loadOptions, int? idpago = 0)
        {
            var result = await _genericProxy.GetAsync<Asignacion_PlandePago>("Pago/GetMesesPagar/" + idasignacion + "?idpago=" + idpago);
            if (result.Succeeded == true)
                return new JsonResult(DataSourceLoader.Load(result.Datas, loadOptions));

            return new JsonResult(DataSourceLoader.Load(new List<Asignacion_PlandePago>(), loadOptions));
        }

        [HttpGet("GetTicket")]
        public async Task<IActionResult> GetTicket(int idpago)
        {
            RptTicketPago ticketPago = new RptTicketPago();
            var source = await _genericProxy.GetAsync<TicketPago>("Pago/GetTicket/" + idpago);
            var path = Path.Combine(_env.ContentRootPath, "Reports");
            ticketPago.LoadLayout(path + "\\RptTicketPago.repx");
            ticketPago.DataSource = source.Datas;
            ticketPago.DataMember = ticketPago.DataMember;

            return View("PartialTicket",ticketPago);
        }

        [HttpGet("GetGrafico")]
        public async Task<IActionResult> GetGrafico(DataSourceLoadOptions loadOptions,string Fecha)
        {
            var result = await _genericProxy.GetAsync<ViewGraficoPagos>("Pago/GetGrafico?fechapago=" + Fecha);
            if(result.Succeeded==true)
                return new JsonResult(DataSourceLoader.Load(result.Datas, loadOptions));

            return new JsonResult(DataSourceLoader.Load(new List<ViewGraficoPagos>(), loadOptions));
        }
    }



    }
