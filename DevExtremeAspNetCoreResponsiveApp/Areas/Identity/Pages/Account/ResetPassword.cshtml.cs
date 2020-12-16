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
            public string Email { get; set; }
            [Required]
            [Display(Name ="Ingrese el Código recibido")]
            public string Token { get; set; }
            [Required]
            [MinLength(8)]
            [StringLength(12, ErrorMessage = "La contraseña debe tener al menos {2} caracteres.", MinimumLength = 8)]
            [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d))(?=.*[^\da-zA-Z]).+$", ErrorMessage = "Contraseña no válida")]
            [Display(Name = "Ingrese la nueva contraseña")]
            [DataType(DataType.Password)]
            public string Password { get; set; }
            [Required]
            [MinLength(8)]
            [StringLength(12, ErrorMessage = "La contraseña debe tener al menos {2} caracteres.", MinimumLength = 8)]
            [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d))(?=.*[^\da-zA-Z]).+$", ErrorMessage = "Contraseña no válida")]
            [Compare("Password")]
            [Display(Name = "Ingrese la confirmación de la contraseña")]
            [DataType(DataType.Password)]
            public string ConfirmPassword { get; set; }
        }

        public void OnGet(string? email)
        {
            Input = new ResetPasswordRequest();
            if (email != null)
                Input.Email = email;
        }

        public async Task<IActionResult> OnPost([FromForm] string Email)
        {
            Input.Email = Email;
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
