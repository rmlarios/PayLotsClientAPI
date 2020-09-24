using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DevExtremeAspNetCoreResponsiveApp.Model;
using DevExtreme.AspNet.Mvc;
using DevExtreme.AspNet.Data;
using DevExtremeAspNetCoreResponsiveApp.Controladores;

namespace DevExtremeAspNetCoreResponsiveApp.Pages.ListaBeneficiarios
{
    public class BeneficiariosModel : PageModel
    {
        [TempData]
        public string Mensaje { get; set; }

        private readonly DevExtremeAspNetCoreResponsiveApp.Model.PayLotsDBContext _context;
        public static PayLotsDBContext context  { get; set; }

        public BeneficiariosModel(DevExtremeAspNetCoreResponsiveApp.Model.PayLotsDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Beneficiarios> Beneficiarios { get;set; }
        BeneficiariosController beneficiariosController = new BeneficiariosController(context);

        public async Task OnGetAsyncBeneficiarios()
        {
            Beneficiarios = await _context.Beneficiarios.ToListAsync();
        }
   
        public JsonResult OnGetBeneficiarios(DataSourceLoadOptions options)
        {

            //JsonResult result = await OnGetBeneficiarios(options);
            return new JsonResult(DataSourceLoader.Load(_context.Beneficiarios.ToList(), options));
            //object obj = await beneficiariosController.Get(options);
            ///JsonResult result = new JsonResult(obj);
            //return result;
        }

  
        public void OnDelete(int key)
        {
            var beneficiarios =  _context.Beneficiarios.Find(key);
            if (beneficiarios == null)
            {
                Mensaje = "Registro No Encontrado";
            }

            _context.Beneficiarios.Remove(beneficiarios);
             _context.SaveChanges();
            //return RedirectToPage("Beneficiarios");
        }
    }
}
