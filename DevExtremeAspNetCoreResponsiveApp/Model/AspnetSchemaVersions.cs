using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevExtremeAspNetCoreResponsiveApp.Model
{
    [Table("aspnet_SchemaVersions")]
    public partial class AspnetSchemaVersions
    {
        [StringLength(128)]
        public string Feature { get; set; }
        [StringLength(128)]
        public string CompatibleSchemaVersion { get; set; }
        public bool IsCurrentVersion { get; set; }
    }
}
