using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevExtremeAspNetCoreResponsiveApp.Model
{
    [Table("aspnet_Paths")]
    public partial class AspnetPaths
    {
        public AspnetPaths()
        {
            AspnetPersonalizationPerUser = new HashSet<AspnetPersonalizationPerUser>();
        }

        public Guid ApplicationId { get; set; }
        [Key]
        public Guid PathId { get; set; }
        [Required]
        [StringLength(256)]
        public string Path { get; set; }
        [Required]
        [StringLength(256)]
        public string LoweredPath { get; set; }

        [ForeignKey("ApplicationId")]
        [InverseProperty("AspnetPaths")]
        public AspnetApplications Application { get; set; }
        [InverseProperty("Path")]
        public AspnetPersonalizationAllUsers AspnetPersonalizationAllUsers { get; set; }
        [InverseProperty("Path")]
        public ICollection<AspnetPersonalizationPerUser> AspnetPersonalizationPerUser { get; set; }
    }
}
