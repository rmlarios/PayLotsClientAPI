using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class AspNetUserRoles
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }

        public virtual AspNetRoles1 Role { get; set; }
        public virtual AspNetUsers1 User { get; set; }
    }
}
