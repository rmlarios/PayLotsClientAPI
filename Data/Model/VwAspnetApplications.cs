using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class VwAspnetApplications
    {
        public string ApplicationName { get; set; }
        public string LoweredApplicationName { get; set; }
        public Guid ApplicationId { get; set; }
        public string Description { get; set; }
    }
}
