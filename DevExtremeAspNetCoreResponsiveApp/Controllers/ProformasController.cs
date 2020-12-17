using Data.Model;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevExtremeAspNetCoreResponsiveApp.Controllers
{
    public class ProformasController : GenericController<Proformas>
    {

        public ProformasController(IGenericProxy genericProxy, IToastNotification toastNotification) : base(genericProxy, toastNotification, "Proforma/", "Listar", "")
        {
        }
    }
}
