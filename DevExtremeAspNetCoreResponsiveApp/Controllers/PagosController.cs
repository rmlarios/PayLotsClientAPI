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
using Microsoft.AspNetCore.Http;

namespace DevExtremeAspNetCoreResponsiveApp.Controllers
{
    public class PagosController : GenericController<ViewPagosAsignaciones>
    {
        private readonly IHostingEnvironment _env;
        IToastNotification _toastNotification;
        //private readonly IGenericProxy _proxy;
        public PagosController(IGenericProxy genericProxy, IToastNotification toastNotification, IHostingEnvironment env) : base(genericProxy, toastNotification, "Pago/", "GetListado?vigentes=" + true, "GetByAsignacion/")
        {
            //_proxy = genericProxy;
            _env = env;
            _toastNotification = toastNotification;
        }


        [HttpGet("GetPlan")]
        public async Task<IActionResult> GetPlan(int idasignacion, DataSourceLoadOptions loadOptions,string opcion= "A LA FECHA")
        {
            if (idasignacion != 0)
            {
                var result = await _genericProxy.GetAsync<EstadoCuenta>("Pago/GetPlanPago/" + idasignacion+"?opcion="+opcion);
                return new JsonResult(DataSourceLoader.Load(result.Datas, loadOptions));
            }
            else
            {
                List<EstadoCuenta> empty = new List<EstadoCuenta>();
                var result = new Response<EstadoCuenta>(empty);
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
            if (source.Datas[0].Estado == "Anulado")
            {
                ticketPago.Watermark.Text = "ANULADO";
                ticketPago.Watermark.ForeColor = System.Drawing.Color.Red;
                ticketPago.Watermark.TextDirection = DevExpress.XtraPrinting.Drawing.DirectionMode.BackwardDiagonal;
            }
            return View("PartialTicket", ticketPago);
        }

        [HttpGet("GetGrafico")]
        public async Task<IActionResult> GetGrafico(DataSourceLoadOptions loadOptions, string Fecha = "")
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
                            Fecha = a.FechaRecibo.Value != null ? a.FechaRecibo.Value.Date : a.FechaRecibo.Value,
                            Pagado = a.MontoPago + a.Inter�s + a.Mora,
                        }).GroupBy(x => x.Fecha) // 1
                        .Select(grp => new //2
                        {
                            Fecha = grp.Key,
                            name = grp.First().Fecha, // same ID => same name anyway
                            Pagado = grp.Sum(b => b.Pagado) //3
                        }).OrderByDescending(o => o.Fecha).Take(7)
                .Where(w => w.Fecha != null); //4
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
            if (result.Succeeded)
            {
                //return new JsonResult(DataSourceLoader.Load(result.Datas, loadOptions));
                LoadResult newresult = new LoadResult();
                newresult.totalCount = result.Count;
                newresult.data = result.Datas;
                return new OkObjectResult(newresult);
            }
            return new JsonResult(DataSourceLoader.Load(new List<ViewPagosAsignaciones>(), loadOptions));
        }

        [HttpGet("GetAnulados")]
        public async Task<IActionResult> GetAnulados(DataSourceLoadOptions loadOptions)
        {
            string Query = "";
            if (loadOptions.Take != 0 || loadOptions.Skip != 0)
                Query = "?take=" + loadOptions.Take + "&skip=" + loadOptions.Skip;

            var result = await _genericProxy.GetAsync<Seguimientos>("Pago/GetPagosAnulados" + Query);
            if (result.Succeeded)
            {
                //return new JsonResult(DataSourceLoader.Load(result.Datas, loadOptions));
                LoadResult newresult = new LoadResult();
                newresult.totalCount = result.Count;
                newresult.data = result.Datas;
                return new OkObjectResult(newresult);
            }
            return new JsonResult(DataSourceLoader.Load(new List<Seguimientos>(), loadOptions));
        }

        [HttpPost]
        public async Task<IActionResult> Anular([FromForm] AnularPagoRequest values)
        {
            string url = Request.GetTypedHeaders().Referer.ToString();

            //JsonConvert.PopulateObject(values, entity);
            var result = await _genericProxy.PostAsync<AnularPagoRequest>("Pago/Anular", values);
            if (result.Succeeded)
            {
                _toastNotification.AddSuccessToastMessage(result.Message);
                return Ok(values.IdPago);
                //TempData["Msg"] = "Uploaded successfully";        
                //return new OkObjectResult(result.Message);
            }
            else
            {
                _toastNotification.AddErrorToastMessage(result.Message);
                return BadRequest(error: result.Message);
                //TempData["Msg"] = "Uploaded error"; 
                //return BadRequest(result.Message);
            }
            //return Redirect(url);
            //return LocalRedirect("~/Asignacion/Listado");
            //return View();
        }

    }



}
