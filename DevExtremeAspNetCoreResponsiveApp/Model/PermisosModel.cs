using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevExtremeAspNetCoreResponsiveApp.Model
{
    public class PermisosModel
    {
        public string UserId { get; set; }
        public IList<UserClaimsViewModel> UserClaims { get; set; }
    }

    public class UserClaimsViewModel
    {
        public string Type { get; set; }
        public string Value { get; set; }
        public bool Selected { get; set; }
    }
}
