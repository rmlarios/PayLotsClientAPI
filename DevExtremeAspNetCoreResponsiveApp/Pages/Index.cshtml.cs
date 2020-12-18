using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DevExtremeAspNetCoreResponsiveApp.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public ViewDashboard dashboard { get; set; } = new ViewDashboard();
        public void OnGet()
        {

        }
    }
}
