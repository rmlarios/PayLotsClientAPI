using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class Seguimientos
    {
        public int IdSeguimiento { get; set; }
        public string Observaciones { get; set; }
        public string Tipo { get; set; }
        public int IndexSql { get; set; }
        public DateTime Far { get; set; }
        public string Uar { get; set; }
    }
}
