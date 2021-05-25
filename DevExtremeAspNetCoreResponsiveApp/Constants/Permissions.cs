using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevExtremeAspNetCoreResponsiveApp.Constants
{
    public static class Permissions
    {
        public static List<string> GeneratePermissionsForModule(string module)
        {
            return new List<string>()
            {
                $"Permisos.{module}.Crear",
                $"Permisos.{module}.Ver",
                $"Permisos.{module}.Editar",
                $"Permisos.{module}.Eliminar",
            };
        }

        public static class Pagos
        {
            public const string Editar = "Permisos.Pagos.Editar";
            
        }
    }
}
