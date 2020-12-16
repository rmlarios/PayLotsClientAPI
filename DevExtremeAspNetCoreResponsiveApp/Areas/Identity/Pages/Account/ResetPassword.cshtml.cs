using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NToastNotify;

namespace DevExtremeAspNetCoreResponsiveApp.Areas.Identity.Pages.Account
{
    public class ResetPasswordModel : PageModel
    {
        private readonly IGenericProxy _genericProxy;
        private readonly IToastNotification _toastNotification;
        [BindProperty]
        public ResetPasswordRequest Input { get; set; } 
        public ResetPasswordModel(IGenericProxy genericProxy, IToastNotification toastNotification)
        {
            _genericProxy = genericProxy;
            _toastNotification = toastNotification;
        }
        public class ResetPasswordRequest
        {
            [Required]
            [EmailAddress]
            [Display(Name ="Se envió un código de confirmación a: ")]
            public string emailreset { get; set; }
            [Required]
            public string Token { get; set; }
            [Required]
            [MinLength(6)]
            public string Password { get; set; }
            [Required]
            [Compare("Password")]
            public string ConfirmPassword { get; set; }
        }

        public void OnGet(string? email)
        {
            Input = new ResetPasswordRequest();
            if (email != null)
                Input.emailreset = email;
        }

        public async Task<IActionResult> OnPost([FromForm] string emailreset)
        {
            Input.emailreset = emailreset;
            var result = await _genericProxy.PostAsync<ResetPasswordRequest>("Account/ResetPassword", Input);
            if (result.Succeeded)
            {
                //return RedirectToPage("./ForgotPasswordConfirmation");                    
                _toastNotification.AddSuccessToastMessage(result.Message);
                return new JsonResult(Input);
            }
            else
            {
                _toastNotification.AddErrorToastMessage(result.Message);
                return BadRequest();
                //return RedirectToPage("./ForgotPasswordConfirmation");
            }

        }
    }
}
