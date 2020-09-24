using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevExtremeAspNetCoreResponsiveApp.Model
{
    [Table("aspnet_UsersInRoles")]
    public partial class AspnetUsersInRoles
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }

        [ForeignKey("RoleId")]
        [InverseProperty("AspnetUsersInRoles")]
        public AspnetRoles Role { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("AspnetUsersInRoles")]
        public AspnetUsers User { get; set; }
    }
}
