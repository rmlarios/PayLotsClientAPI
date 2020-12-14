using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using DevExtremeAspNetCoreResponsiveApp.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DevExtremeAspNetCoreResponsiveApp.Helpers;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using NToastNotify;

namespace DevExtremeAspNetCoreResponsiveApp.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ForgotPasswordModel : PageModel
    {
        private readonly IGenericProxy _genericProxy;
        private readonly IToastNotification _toasNotification;

        public ForgotPasswordModel(IGenericProxy genericProxy, IToastNotification toastNotification)
        {
            _genericProxy = genericProxy;
            _toasNotification = toastNotification;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Correo Electrónico")]
            public string Email { get; set; }
        }

        public async Task<IActionResult> OnPostAsync(string email)
        {
            if (ModelState.IsValid)
            {
                var result = await _genericProxy.PostAsync<string>("Account/ForgotPassword", Input.Email);
                if (result.Succeeded)
                {
                    return RedirectToPage("./ForgotPasswordConfirmation");
                }
                else
                {
                    _toasNotification.AddErrorToastMessage(result.Message);
                    return RedirectToPage("./ForgotPasswordConfirmation");
                }
                //var user = await _userHelper.GetUserByEmailAsync(Input.Email);
                //if (user == null || !(await _userHelper.IsEmailConfirmedAsync(user)))
                //{
                //    // Don't reveal that the user does not exist or is not confirmed
                //    return RedirectToPage("./ForgotPasswordConfirmation");
                //}

                //// For more information on how to enable account confirmation and password reset please 
                //// visit https://go.microsoft.com/fwlink/?LinkID=532713
                //var code = await _userHelper.GeneratePasswordResetTokenAsync(user);
                //var callbackUrl = Url.Page(
                //    "/Account/ResetPassword",
                //    pageHandler: null,
                //    values: new { code },
                //    protocol: Request.Scheme);

                //await _emailSender.SendEmailAsync(
                //    Input.Email,
                //    "Cambiar Contraseña",
                //    $"Favor cambiar su contraseña <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>haciendo click aqui.</a>.");

                //return RedirectToPage("./ForgotPasswordConfirmation");
            }

            return Page();
        }
    }
}
