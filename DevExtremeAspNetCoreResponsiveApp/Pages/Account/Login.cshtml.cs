using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtremeAspNetCoreResponsiveApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DevExtremeAspNetCoreResponsiveApp.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public LoginView login { get; set; }

        public void OnGet()
        {

        }
    }
}