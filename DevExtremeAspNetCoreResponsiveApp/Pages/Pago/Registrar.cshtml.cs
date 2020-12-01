using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Model;
using DevExtremeAspNetCoreResponsiveApp.DTOs;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NToastNotify;

namespace DevExtremeAspNetCoreResponsiveApp.Pages.Pago
{
    public class RegistrarModel : PageModel
    {
        
        private IGenericProxy _genericProxy;
        private readonly IToastNotification _toastNotification;
        [BindProperty]
        public ViewAsignacionesSaldo Asignaciones { get; set; }
        [BindProperty]
        public ViewPagosAsignaciones pago { get; set; }
        public RegistrarModel(IGenericProxy genericProxy, IToastNotification toastNotification)
        {
            _genericProxy = genericProxy;
            _toastNotification = toastNotification;
        }

        public async Task OnGet(string p="0")
        {
            string[] parameters = p.Split('.');
            int idasignacion = 0;
            int idpago = 0;
            if (parameters.Count() > 1)
            {
                idasignacion = Convert.ToInt32(parameters[0]);
                idpago = Convert.ToInt32(parameters[1]);
            }
            else// if(parameters.Count()==1)
            {
                idasignacion = Convert.ToInt32(parameters[0]);
                idpago = 0;
            }

            pago = new ViewPagosAsignaciones();
            pago.IdPago = idpago;

            var resultasig = await _genericProxy.GetAsync<ViewAsignacionesSaldo>("Asignacion/GetDatosbyId/"+idasignacion);
            if (resultasig.Succeeded)
            {
                if (idpago != 0)
                {
                    //var result = await _genericProxy.GetAsync<Pagos>("Pago/GetDatosPago/" + idpago);
                    var result = await _genericProxy.GetAsync<Pagos>("Pago/" + idpago);
                    if (result.Succeeded)
                    {
                        //pago = (ViewPagosAsignaciones)result.Data;                        
                        pago.IdPago = result.Data.IdPago;
                        pago.MesPagado = result.Data.MesPagado;
                        pago.NumeroRecibo = result.Data.NumeroRecibo;
                        pago.FechaRecibo = result.Data.FechaRecibo;
                        pago.MontoEfectivo = result.Data.MontoEfectivo;
                        pago.Moneda = result.Data.Moneda;
                        pago.TasaCambio = result.Data.TasaCambio;
                        pago.Observaciones = result.Data.Observaciones;

                        var DatosMes = await _genericProxy.GetAsync<Asignacion_PlandePago>("Pago/GetMesesPagar/" + idasignacion + " ?idpago=" + idpago);
                        pago.MontoPago = DatosMes.Datas.SingleOrDefault(m => m.MesPagado == pago.MesPagado).MontoMinimo;
                        pago.Interés = DatosMes.Datas.SingleOrDefault(m => m.MesPagado == pago.MesPagado).Interes;
                        pago.Mora = DatosMes.Datas.SingleOrDefault(m => m.MesPagado == pago.MesPagado).Mora;
                    }
                    else
                        pago = new ViewPagosAsignaciones();
                }

                pago.IdAsignacion = resultasig.Datas[0].IdAsignacion;
                pago.IdLote = resultasig.Datas[0].IdLote;
                pago.NombreCompleto = resultasig.Datas[0].NombreCompleto;
                pago.MontoTotal = resultasig.Datas[0].MontoTotal;
                pago.Prima = resultasig.Datas[0].Prima;
                pago.Abonado = resultasig.Datas[0].Abonado;
                pago.Saldo = resultasig.Datas[0].Saldo;
            }
         




           
        }

        public async Task OnPost([FromForm] int IdPago, [FromForm]Pagos entity)
        {
            if (!ModelState.IsValid)
            {
                var Errors = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).Aggregate((U, V) => U + "," + V);
                _toastNotification.AddErrorToastMessage(Errors);
                ModelState.AddModelError("custom", Errors);
                return;
            }

        }
    }
}
