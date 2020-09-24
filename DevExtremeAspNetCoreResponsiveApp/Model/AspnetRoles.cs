using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevExtremeAspNetCoreResponsiveApp.Model
{
    [Table("aspnet_Roles")]
    public partial class AspnetRoles
    {
        public AspnetRoles()
        {
            AspnetUsersInRoles = new HashSet<AspnetUsersInRoles>();
        }

        public Guid ApplicationId { get; set; }
        [Key]
        public Guid RoleId { get; set; }
        [Required]
        [StringLength(256)]
        public string RoleName { get; set; }
        [Required]
        [StringLength(256)]
        public string LoweredRoleName { get; set; }
        [StringLength(256)]
        public string Description { get; set; }

        [ForeignKey("ApplicationId")]
        [InverseProperty("AspnetRoles")]
        public AspnetApplications Application { get; set; }
        [InverseProperty("Role")]
        public ICollection<AspnetUsersInRoles> AspnetUsersInRoles { get; set; }
    }
}
