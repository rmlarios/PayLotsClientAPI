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
using System.Linq;
using System;
using DevExtreme.AspNet.Data.ResponseModel;

namespace DevExtremeAspNetCoreResponsiveApp.Controllers
{
    public class PagosController : GenericController<ViewPagosAsignaciones>
    {
        private readonly IHostingEnvironment _env;
        //private readonly IGenericProxy _proxy;
        public PagosController(IGenericProxy genericProxy, IToastNotification toastNotification, IHostingEnvironment env) : base(genericProxy, toastNotification, "Pago/", "GetListado?vigentes=" + true, "GetByAsignacion/")
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

            return View("PartialTicket", ticketPago);
        }

        [HttpGet("GetGrafico")]
        public async Task<IActionResult> GetGrafico(DataSourceLoadOptions loadOptions, string Fecha="")
        {
            var result = await _genericProxy.GetAsync<ViewGraficoPagos>("Pago/GetGrafico?fechapago=" + Fecha);
            if (result.Succeeded == true)
                return new JsonResult(DataSourceLoader.Load(result.Datas, loadOptions));

            return new JsonResult(DataSourceLoader.Load(new List<ViewGraficoPagos>(), loadOptions));
        }

        [HttpGet("GetMorosos")]
        public async Task<IActionResult> GetMorosos(DataSourceLoadOptions loadOptions)
        {
            var result = await _genericProxy.GetAsync<ViewReporteMorosos>("Pago/GetMorosos");
            if (result.Succeeded)
                return new JsonResult(DataSourceLoader.Load(result.Datas, loadOptions));

            return new JsonResult(DataSourceLoader.Load(new List<ViewReporteMorosos>(), loadOptions));
        }

        [HttpGet("GetUltimosPagos")]
        public async Task<IActionResult> GetUtltimosPagos(DataSourceLoadOptions loadOptions)
        {
            var result = await _genericProxy.GetAsync<ViewPagosAsignaciones>("Pago/GetListado?vigentes=" + false);
            if (result.Succeeded == true)
            {
                var data = result.Datas.Where(x => x.FechaRecibo != null);
                var res = (
                        from a in data
                        select new
                        {
                            Fecha = a.FechaRecibo.Value!=null? a.FechaRecibo.Value.Date:a.FechaRecibo.Value,
                            Pagado = a.MontoPago + a.Interés + a.Mora,
                        }).GroupBy(x => x.Fecha) // 1
                        .Select(grp => new //2
                        {
                            Fecha = grp.Key,
                            name = grp.First().Fecha, // same ID => same name anyway
                            Pagado = grp.Sum(b => b.Pagado) //3
                        }).OrderByDescending(o=>o.Fecha).Take(7)
                .Where(w=>w.Fecha!=null); //4
                return new JsonResult(DataSourceLoader.Load(res, loadOptions));
            }

            return new JsonResult(DataSourceLoader.Load(new List<ViewGraficoPagos>(), loadOptions));
        }
    
    [HttpGet("GetTodos")]
    public async Task<IActionResult> GetTodos(DataSourceLoadOptions loadOptions)
        {
            string Query = "";
            if (loadOptions.Take != 0 || loadOptions.Skip != 0)
                Query = "&take=" + loadOptions.Take + "&skip=" + loadOptions.Skip;

            var result = await _genericProxy.GetAsync<ViewPagosAsignaciones>("Pago/GetListado?vigentes=" + false + Query);
            if(result.Succeeded)
            {
                //return new JsonResult(DataSourceLoader.Load(result.Datas, loadOptions));
                LoadResult newresult = new LoadResult();
                newresult.totalCount = result.Count;
                newresult.data = result.Datas;
                return new OkObjectResult(newresult);
            }
            return new JsonResult(DataSourceLoader.Load(new List<ViewPagosAsignaciones>(), loadOptions));
        }
    }



}
