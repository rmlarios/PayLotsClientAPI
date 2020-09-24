using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevExtremeAspNetCoreResponsiveApp.Model
{
    [Table("aspnet_PersonalizationAllUsers")]
    public partial class AspnetPersonalizationAllUsers
    {
        [Key]
        public Guid PathId { get; set; }
        [Required]
        [Column(TypeName = "image")]
        public byte[] PageSettings { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastUpdatedDate { get; set; }

        [ForeignKey("PathId")]
        [InverseProperty("AspnetPersonalizationAllUsers")]
        public AspnetPaths Path { get; set; }
    }
}
