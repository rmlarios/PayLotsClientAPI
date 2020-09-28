using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class AspnetPersonalizationPerUser
    {
        public Guid Id { get; set; }
        public Guid? PathId { get; set; }
        public Guid? UserId { get; set; }
        public byte[] PageSettings { get; set; }
        public DateTime LastUpdatedDate { get; set; }

        public virtual AspnetPaths Path { get; set; }
        public virtual AspnetUsers User { get; set; }
    }
}
