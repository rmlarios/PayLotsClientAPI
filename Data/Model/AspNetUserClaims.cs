using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class AspNetUserClaims
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual AspNetUsers1 User { get; set; }
    }
}
