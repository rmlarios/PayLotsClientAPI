using Data.Model;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevExtremeAspNetCoreResponsiveApp.Controllers
{
    public class AbonosPrimaController : GenericController<ViewAbonosPrima>
    {
        public AbonosPrimaController(IGenericProxy genericProxy, IToastNotification toastNotification) : base(genericProxy, toastNotification, "AbonosPrima/", "GetListado","")
        {
        }
    }
}
