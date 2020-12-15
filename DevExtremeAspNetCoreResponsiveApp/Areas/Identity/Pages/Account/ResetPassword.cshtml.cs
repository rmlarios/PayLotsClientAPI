using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DevExtremeAspNetCoreResponsiveApp.Areas.Identity.Pages.Account
{
    public class ResetPasswordModel : PageModel
    {
        [BindProperty]
        public ResetPasswordRequest Input { get; set; }
        public ResetPasswordModel()
        {

        }
        public class ResetPasswordRequest
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }
            [Required]
            public string Token { get; set; }
            [Required]
            [MinLength(6)]
            public string Password { get; set; }
            [Required]
            [Compare("Password")]
            public string ConfirmPassword { get; set; }
        }

        public void OnGet()
        {
        }

        public void OnPost()
        { }
    }
}
