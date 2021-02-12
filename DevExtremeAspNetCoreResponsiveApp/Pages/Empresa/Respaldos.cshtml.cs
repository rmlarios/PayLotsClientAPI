using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DevExtremeAspNetCoreResponsiveApp.Model;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NToastNotify;

namespace DevExtremeAspNetCoreResponsiveApp.Pages.Empresa
{
    public class RespaldosModel : PageModel
    {

        public class Backups
        {
            public string NombreArchivo { get; set; }
            public string FechaCreacion { get; set; }
        }
        [BindProperty]
        public List<Backups> Listado { get; set; } = new List<Backups>();

        private readonly IGenericProxy _genericProxy;
        private readonly IToastNotification _toastNotification;
        private readonly IHostingEnvironment _env;
        public RespaldosModel(IGenericProxy genericProxy, IToastNotification toastNotification, IHostingEnvironment env)
        {
            _genericProxy = genericProxy;
            _toastNotification = toastNotification;
            _env = env;
        }
        public void OnGet()
        {
            CargarRespaldos();
        }

        public void CargarRespaldos()
        {
            try
            {
                DataTable Data = new DataTable();
                Data.Columns.Add("NombreArchivo");
                Data.Columns.Add("FechaCreacion");
                string Ruta = Path.Combine(_env.ContentRootPath, "Reports");
                if (System.IO.Directory.Exists(Ruta))
                {
                    string[] files = System.IO.Directory.GetFiles(Ruta, "*.bak");
                    foreach (string s in files)
                    {
                        if (System.IO.File.Exists(s))
                        {
                            FileInfo Info = new FileInfo(s);
                            string NombreArch = s.Replace(Ruta, "").Replace("\\", "");
                            string FechaCreac = Info.CreationTime.ToString();
                            Info.Length.ToString();
                            //ListReportes.Items.Add(s.Replace(Ruta, ""), s.Replace(Ruta, ""), "~/Content/report-icon-32.jpg");
                            Listado.Add(new Backups() { FechaCreacion = FechaCreac,NombreArchivo=NombreArch });
                            // Data.Rows.Add(new Object[] { NombreArchivo, FechaCreacion });

                        }
                    }
                    

                }
            }
            catch (Exception Ex)
            {
                //FG.Controlador_Error(Ex, Page.Response);
            }
        }

        public async Task<ActionResult> OnPostAsync()
        {
            RespaldoRequest request = new RespaldoRequest();
            var path = Path.Combine(_env.ContentRootPath, "Reports");
            request.Path = path;
            var result = await _genericProxy.PostAsync<RespaldoRequest>("DatosEmpresa/Backup",request);
            if (result.Succeeded)
            {
                _toastNotification.AddSuccessToastMessage("Respaldo creado correctamente.");
                MemoryStream m = new MemoryStream();
                path = path + "\\" + result.Message;
                Listado.Add(new Backups() { FechaCreacion = DateTime.Now.ToString(), NombreArchivo = result.Message });
                return OnGetDownloadFile(path,result.Message);
                /*byte[] reportContent = System.IO.File.ReadAllBytes(path);
                Response.ContentType = "application/pdf";
                Response.Clear();
                Response.ContentType = "application/pdf";
                Response.Headers.Add("Content-Disposition", String.Format("{0}; filename={1}", "attachment", result.Message));
                Response.Body.Write(reportContent);
                Response.Body.Write.END .End();*/

            }
            else
            {
                _toastNotification.AddErrorToastMessage(result.Message);
                return BadRequest();
               
            }
        }

        public FileResult OnGetDownloadFile(string path,string fileName)
        {
            //Build the File Path.
            //string path = Path.Combine(this.Environment.WebRootPath, "Files/") + fileName;

            //Read the File data into Byte Array.
            byte[] bytes = System.IO.File.ReadAllBytes(path);

            //Send the File to Download.
            return File(bytes, "application/octet-stream", fileName);
        }
    }
}
