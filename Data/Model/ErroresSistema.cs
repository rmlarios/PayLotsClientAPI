using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class ErroresSistema
    {
        public int IdErrorSistema { get; set; }
        public string Error { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public string Pantalla { get; set; }
        public string CodError { get; set; }
    }
}
