using Data.Model;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using DevExtremeAspNetCoreResponsiveApp.Model;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using DevExtremeAspNetCoreResponsiveApp.Proxies.Models;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevExtremeAspNetCoreResponsiveApp.Controllers
{
    public class UsersController : GenericController<AppUserModel>
    {
        public UsersController(IGenericProxy genericProxy, IToastNotification toastNotification) : base(genericProxy, toastNotification, "Account/", "getallusers", "")
        {
        }

        [HttpGet("GetRoles")]
        public async Task<IActionResult> GetRoles(DataSourceLoadOptions loadOptions)
        {
            var result = await _genericProxy.GetAsync<string>("Account/GetRoles/");
            return new JsonResult(DataSourceLoader.Load(result.Datas, loadOptions));
        }

        [HttpPost("ForgotPassword")]
        public async Task<IActionResult> ForgotPassword([FromForm]string Email)
        {
            return Ok();
        }


    }
}
