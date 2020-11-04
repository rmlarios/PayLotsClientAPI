using System;
using Data.Model;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using NToastNotify;

namespace DevExtremeAspNetCoreResponsiveApp.Controllers
{
    public class MoraController : GenericController<Mora>
    {
        public MoraController(IGenericProxy genericProxy, IToastNotification toastNotification):base(genericProxy,toastNotification,"Mora/","Listar","")
        {
            
        }
    }
}
