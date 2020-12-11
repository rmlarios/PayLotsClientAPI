using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DevExtremeAspNetCoreResponsiveApp.Areas.Identity.Pages.Account
{
    public class ConfirmEmailModel : PageModel
    {
        [TempData]
        public string StatusMessage { get; set; }
        private readonly IGenericProxy _genericProxy;
        public ConfirmEmailModel(IGenericProxy genericProxy)
        {
            _genericProxy = genericProxy;
        }
        public async Task<IActionResult> OnGetAsync(string userId,string code)
        {
            if (userId == null || code == null)
            {
                return RedirectToPage("/Index");
            }

            var result = await _genericProxy.GetAsync<string>("Account/confirm-email/?userId=" + userId + "&code="+code);
            StatusMessage = result.Succeeded ? "Gracias por confirmar su cuenta." : "Error al confirmar su cuenta.";
            return Page();
        }
    }
}
