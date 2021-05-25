using DevExtremeAspNetCoreResponsiveApp.Model;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace DevExtremeAspNetCoreResponsiveApp.Helpers
{
    public static class ClaimsHelper
    {
        public static void GetPermissions(this List<UserClaimsViewModel> allPermissions, Type policy, string roleId)
        {
            FieldInfo[] fields = policy.GetFields(BindingFlags.Static | BindingFlags.Public);
            foreach (FieldInfo fi in fields)
            {
                allPermissions.Add(new UserClaimsViewModel { Value = fi.GetValue(null).ToString(), Type = "Permisos" });
            }
           
        }
       
    }
}
