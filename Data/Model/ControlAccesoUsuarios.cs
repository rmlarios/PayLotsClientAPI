using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class ControlAccesoUsuarios
    {
        public int IdLogueo { get; set; }
        public string SesionId { get; set; }
        public string Usuario { get; set; }
        public string Perfil { get; set; }
        public DateTime? Far { get; set; }
        public string Pc { get; set; }
    }
}
