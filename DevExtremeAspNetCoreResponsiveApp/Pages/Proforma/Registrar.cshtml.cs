using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Model;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NToastNotify;

namespace DevExtremeAspNetCoreResponsiveApp.Pages.Proforma
{
    public class RegistrarModel : PageModel
    {
        [BindProperty]
        public Proformas proforma { get; set; } = new Proformas();
        private readonly IGenericProxy _genericProxy;
        private readonly IToastNotification _toastNotification;

        public RegistrarModel(IGenericProxy genericProxy,IToastNotification toastNotification)
        {
            _genericProxy = genericProxy;
            _toastNotification = toastNotification;
        }

        public async Task OnGet(int p=0)
        {
            if(p!=0)
            {
                var result = await _genericProxy.GetAsync<Proformas>("Proforma/" + p);
                if (result.Succeeded)
                    proforma = result.Data;
            }

        }

        public async Task OnPostAsync([FromForm]int IdProforma)
        {

            var result = await _genericProxy.PostAsync<Proformas>("Proforma/Save/"+ IdProforma, proforma);
            if(result.Succeeded)
            {
                _toastNotification.AddSuccessToastMessage(result.Message);
                await OnGet(result.Data.IdProforma);
            }
            else
            {
                _toastNotification.AddErrorToastMessage(result.Message);
                return;
            }


        }
    }
}
