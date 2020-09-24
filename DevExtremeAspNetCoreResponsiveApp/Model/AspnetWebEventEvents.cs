using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevExtremeAspNetCoreResponsiveApp.Model
{
    [Table("aspnet_WebEvent_Events")]
    public partial class AspnetWebEventEvents
    {
        [Key]
        [StringLength(32)]
        public string EventId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EventTimeUtc { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EventTime { get; set; }
        [Required]
        [StringLength(256)]
        public string EventType { get; set; }
        [Column(TypeName = "decimal(19, 0)")]
        public decimal EventSequence { get; set; }
        [Column(TypeName = "decimal(19, 0)")]
        public decimal EventOccurrence { get; set; }
        public int EventCode { get; set; }
        public int EventDetailCode { get; set; }
        [StringLength(1024)]
        public string Message { get; set; }
        [StringLength(256)]
        public string ApplicationPath { get; set; }
        [StringLength(256)]
        public string ApplicationVirtualPath { get; set; }
        [Required]
        [StringLength(256)]
        public string MachineName { get; set; }
        [StringLength(1024)]
        public string RequestUrl { get; set; }
        [StringLength(256)]
        public string ExceptionType { get; set; }
        [Column(TypeName = "ntext")]
        public string Details { get; set; }
    }
}
