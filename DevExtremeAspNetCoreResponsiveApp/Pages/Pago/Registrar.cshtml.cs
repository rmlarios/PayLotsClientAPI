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
            }

            if (idpago != 0)
            {
                var result = await _genericProxy.GetAsync<ViewPagosAsignaciones>("Pago/GetDatosPago/" + idpago);
                if (result.Succeeded)
                {
                    pago = result.Data;
                    var DatosMes = await _genericProxy.GetAsync<Asignacion_PlandePago>("Pago/GetMesesPagar/"+idasignacion+" ?idpago="+idpago);
                    pago.MontoPago = DatosMes.Datas.SingleOrDefault(m => m.MesPagado == pago.MesPagado).MontoMinimo;
                    pago.Interés = DatosMes.Datas.SingleOrDefault(m => m.MesPagado == pago.MesPagado).Interes;
                    pago.Mora = DatosMes.Datas.SingleOrDefault(m => m.MesPagado == pago.MesPagado).Mora;
                    

                }
                else
                    pago = new ViewPagosAsignaciones();
            }
        }
    }
}
