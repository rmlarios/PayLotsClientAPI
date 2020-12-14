using System;
using System.IO;
using Data.Model;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace DevExtremeAspNetCoreResponsiveApp.Controllers
{
    public class EmpresaController : GenericController<DatosEmpresa>
    {
        private readonly IHostingEnvironment _env;
        public EmpresaController(IGenericProxy genericProxy, IToastNotification toastNotification,IHostingEnvironment env) : base(genericProxy, toastNotification, "DatosEmpresa/", "Listar", "")
        {
            _env = env;
        }

        [HttpPost]
        public ActionResult UploadLogo()
        {
            // Learn more on the functionality of the dxFileUploader widget at:
            // http://js.devexpress.com/Documentation/Guide/UI_Widgets/UI_Widgets_-_Deep_Dive/dxFileUploader/
            try
            {
                var myFile = Request.Form.Files["imglogo"];
                var path = Path.Combine(_env.WebRootPath, "TempImg");
                // Uncomment to save the file
                if(!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                using(var fileStream = System.IO.File.Create(Path.Combine(path, myFile.FileName))) {
                    myFile.CopyTo(fileStream);
                }
            }
            catch
            {
                Response.StatusCode = 400;
            }

            return new EmptyResult();
        }

    }
}