using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NToastNotify;
using Data.Model;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace DevExtremeAspNetCoreResponsiveApp.Pages.Empresa
{
    public class RegistrarDatosEmpresaModel : PageModel
    {
        private readonly IGenericProxy _genericProxy;
        private readonly IToastNotification _toastNotification;
        [BindProperty]
        public DatosEmpresa datosEmpresa { get; set; }
        public string LogoURL { get; set; } = "";

        public RegistrarDatosEmpresaModel(IGenericProxy genericProxy, IToastNotification toasNotification)
        {
            _genericProxy = genericProxy;
            _toastNotification = toasNotification;
        }
        public async Task OnGet()
        {
            var result = await _genericProxy.GetAsync<DatosEmpresa>("DatosEmpresa/Listar");
            if (result.Succeeded)
            {
                datosEmpresa = result.Datas[0];
                await GetBase64();
            }
            else
                datosEmpresa = new DatosEmpresa();
        }

        public async Task OnPostAsync([FromForm] DatosEmpresa entity, IFormFile imglogo)
        {

            if (imglogo != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await imglogo.CopyToAsync(memoryStream);
                    entity.Logo = memoryStream.ToArray();
                    datosEmpresa.Logo = entity.Logo;
                }
            }

           
            var result = await _genericProxy.PostAsync<DatosEmpresa>("DatosEmpresa/Save/" + entity.DatosEmpresaId, entity);
           // GetBase64(entity.Logo);
            if (result.Succeeded)
            {
                _toastNotification.AddSuccessToastMessage(result.Message);
            }
            else
            {
                _toastNotification.AddErrorToastMessage(result.Message);
                GetBase64();
                return;
            }
            await OnGet();
        }

        public async Task GetBase64()
        {
            var result = await _genericProxy.GetAsync<DatosEmpresa>("DatosEmpresa/Listar");
            if (result.Succeeded)
                if (result.Datas[0].Logo != null)
                {
                    var base64 = Convert.ToBase64String(result.Datas[0].Logo);
                    LogoURL = String.Format("data:image/gif;base64,{0}", base64);
                    //TempData["logo"] = LogoURL;
                }
           
        }

    }
}
