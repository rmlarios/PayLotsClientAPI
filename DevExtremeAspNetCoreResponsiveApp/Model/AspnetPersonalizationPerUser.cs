using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevExtremeAspNetCoreResponsiveApp.Model
{
    [Table("aspnet_PersonalizationPerUser")]
    public partial class AspnetPersonalizationPerUser
    {
        public Guid Id { get; set; }
        public Guid? PathId { get; set; }
        public Guid? UserId { get; set; }
        [Required]
        [Column(TypeName = "image")]
        public byte[] PageSettings { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastUpdatedDate { get; set; }

        [ForeignKey("PathId")]
        [InverseProperty("AspnetPersonalizationPerUser")]
        public AspnetPaths Path { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("AspnetPersonalizationPerUser")]
        public AspnetUsers User { get; set; }
    }
}
