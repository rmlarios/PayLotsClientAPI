using DevExtremeAspNetCoreResponsiveApp.Model;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevExtremeAspNetCoreResponsiveApp.Controllers
{
    public class UsersController : GenericController<AppUser>
    {
        public UsersController(IGenericProxy genericProxy, IToastNotification toastNotification) : base(genericProxy, toastNotification, "Account/", "getallusers", "")
        {
        }
    }
}
