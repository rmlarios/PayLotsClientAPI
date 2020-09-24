using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DevExtremeAspNetCoreResponsiveApp.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace DevExtremeAspNetCoreResponsiveApp.Pages.ListaAsignaciones
{
    [Serializable]
    public class RegistrarAsignacionModel : PageModel
    {
        private readonly DevExtremeAspNetCoreResponsiveApp.Model.PayLotsDBContext _context;

        public RegistrarAsignacionModel(DevExtremeAspNetCoreResponsiveApp.Model.PayLotsDBContext context)
        {
            _context = context;
        }


        [BindProperty]
        public Asignaciones Asignaciones { get; set; }
        [Authorize]
        public void OnGet(int id=6087)
        {
        ViewData["IdBeneficiario"] = new SelectList(_context.Beneficiarios, "IdBeneficiario", "NombreCompleto");
        ViewData["IdLote"] = new SelectList(_context.Lotes, "IdLote", "NumeroLote");
            //return Page();
            if (id != 0)
                Asignaciones = _context.Asignaciones.Find(id);
            else
                Asignaciones = new Asignaciones();
            
                
        }
        [HttpPost]
        public async Task<IActionResult> OnPostCreate([FromForm]Asignaciones values)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Asignaciones.Add(values);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        [HttpPost]
        public async Task OnPostClear()
        {
            Asignaciones.IdAsignacion = 0;
        }
        [HttpPut]
        public async Task<ActionResult> OnPutAsync()
        {
            _context.Entry(Asignaciones).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}