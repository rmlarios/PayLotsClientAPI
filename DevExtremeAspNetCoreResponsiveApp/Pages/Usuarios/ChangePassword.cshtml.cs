using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtremeAspNetCoreResponsiveApp.DTOs;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NToastNotify;

namespace DevExtremeAspNetCoreResponsiveApp.Pages.Usuarios
{
    public class ChangePasswordModel : PageModel
    {
        private readonly IGenericProxy _genericProxy;
        private readonly IToastNotification _toastNotification;
        public ChangePasswordModel(IGenericProxy genericProxy, IToastNotification toastNotification)
        {
            _genericProxy = genericProxy;
            _toastNotification = toastNotification;
        }
        [BindProperty]
        public ChangePasswordRequest request { get; set; } 


        public void OnGet()
        {
            request = new ChangePasswordRequest();
        }

        public async Task OnPostAsync([FromForm] ChangePasswordRequest req)
        {
            request.UserName=User.Identity.Name;
            var result = await _genericProxy.PostAsync<ChangePasswordRequest>("Account/ChangePassword/", request);
            // GetBase64(entity.Logo);
            if (result.Succeeded)
            {
                _toastNotification.AddSuccessToastMessage(result.Message);
            }
            else
            {
                _toastNotification.AddErrorToastMessage(result.Message);              
                return;
            }

            OnGet();
        }
    }
}
