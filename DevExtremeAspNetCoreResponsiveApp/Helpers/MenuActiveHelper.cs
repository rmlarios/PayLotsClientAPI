using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevExtremeAspNetCoreResponsiveApp.Helpers
{
    public static class MenuActiveHelper
    {
        public enum Menus
        {
            Catálogos,
            Asignaciones,
            Pagos,
            Reportes
        }

        private class Urls
        {
            public Urls(string U,string A)
            {
                Url = U;
                Area = A;
            }

            public string Url { get; set; }
            public string Area { get; set; }
        }

        private static List<Urls> Paginas { get; set; } = new List<Urls> {
            new Urls("/Ubicacion/Listado","Catálogos"),
            new Urls("/Lote/Listado","Catálogos"),
            new Urls ("/Beneficiario/Listado","Catálogos"),
            new Urls ("/Mora/Listado","Catálogos"),
            new Urls ("/Asignacion/Listado","Asignaciones"),
            new Urls ("/Asignacion/Registrar","Asignaciones"),
            new Urls ("/Proforma/Registrar","Asignaciones"),
            new Urls ("/Pago/Consolidado","Pagos"),
            new Urls ("/Pago/Listado","Pagos"),
            new Urls ("/Pago/Registrar","Pagos"),
            new Urls ("/Pago/Pagos","Pagos"),
            new Urls ("/Pago/AbonosPrima","Pagos"),
            new Urls ("/Reportes/EstadoCuenta","Reportes"),
            new Urls ("/Reportes/PagosporFechas","Reportes"),
            new Urls ("/Reportes/Morosos","Reportes")
            };
        

        public static string MakeAreaMenuOpenClass(this IUrlHelper urlHelper, string area)
        {
            try
            {
                if (urlHelper.ActionContext.RouteData.Values["page"] == null)
                    return null;

                string result = "menu-open";
                //string controllerName = urlHelper.ActionContext.RouteData.Values["area"].ToString();
                string page = urlHelper.ActionContext.RouteData.Values["page"].ToString();
                if (string.IsNullOrEmpty(page)) return null;
               if(Paginas.Any(p=>p.Area==area && p.Url==page))
                //if (page.Equals(area, StringComparison.OrdinalIgnoreCase))
                    return result;

                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
