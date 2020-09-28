using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class ViewGraficoPagos
    {
        public string NombreProyecto { get; set; }
        public decimal? Pagado { get; set; }
        public string Fecha { get; set; }
    }
}
