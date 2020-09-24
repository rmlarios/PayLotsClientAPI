using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace DevExtremeAspNetCoreResponsiveApp.Model.Controllers
{
    [Route("api/[controller]/[action]")]
    public class BeneficiarioController : Controller
    {
        private PayLotsDBContext _context;

        public BeneficiarioController(PayLotsDBContext context) {
            this._context = context;
        }

        [HttpGet]
        public IActionResult Get(DataSourceLoadOptions loadOptions) {
            var beneficiarios = _context.Beneficiarios.Select(i => new {
                i.IdBeneficiario,
                i.NombreCompleto,
                i.CedulaIdentidad,
                i.Direccion,
                i.Telefono,
                i.Uar,
                i.Far,
                i.Uua,
                i.Fua
            });
            return Json(DataSourceLoader.Load(beneficiarios, loadOptions));
        }

        [HttpPost]
        public IActionResult Post(string values) {
            var model = new Beneficiarios();
            var _values = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, _values);

            if(!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));

            var result = _context.Beneficiarios.Add(model);
            _context.SaveChanges();

            return Json(result.Entity.IdBeneficiario);
        }

        [HttpPut]
        public IActionResult Put(int key, string values) {
            var model = _context.Beneficiarios.FirstOrDefault(item => item.IdBeneficiario == key);
            if(model == null)
                return StatusCode(409, "Beneficiarios not found");

            var _values = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, _values);

            if(!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));

            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public void Delete(int key) {
            var model = _context.Beneficiarios.FirstOrDefault(item => item.IdBeneficiario == key);

            _context.Beneficiarios.Remove(model);
            _context.SaveChanges();
        }


        private void PopulateModel(Beneficiarios model, IDictionary values) {
            string ID_BENEFICIARIO = nameof(Beneficiarios.IdBeneficiario);
            string NOMBRE_COMPLETO = nameof(Beneficiarios.NombreCompleto);
            string CEDULA_IDENTIDAD = nameof(Beneficiarios.CedulaIdentidad);
            string DIRECCION = nameof(Beneficiarios.Direccion);
            string TELEFONO = nameof(Beneficiarios.Telefono);
            string UAR = nameof(Beneficiarios.Uar);
            string FAR = nameof(Beneficiarios.Far);
            string UUA = nameof(Beneficiarios.Uua);
            string FUA = nameof(Beneficiarios.Fua);

            if(values.Contains(ID_BENEFICIARIO)) {
                model.IdBeneficiario = Convert.ToInt32(values[ID_BENEFICIARIO]);
            }

            if(values.Contains(NOMBRE_COMPLETO)) {
                model.NombreCompleto = Convert.ToString(values[NOMBRE_COMPLETO]);
            }

            if(values.Contains(CEDULA_IDENTIDAD)) {
                model.CedulaIdentidad = Convert.ToString(values[CEDULA_IDENTIDAD]);
            }

            if(values.Contains(DIRECCION)) {
                model.Direccion = Convert.ToString(values[DIRECCION]);
            }

            if(values.Contains(TELEFONO)) {
                model.Telefono = Convert.ToString(values[TELEFONO]);
            }

            if(values.Contains(UAR)) {
                model.Uar = Convert.ToString(values[UAR]);
            }

            if(values.Contains(FAR)) {
                model.Far = Convert.ToDateTime(values[FAR]);
            }

            if(values.Contains(UUA)) {
                model.Uua = Convert.ToString(values[UUA]);
            }

            if(values.Contains(FUA)) {
                model.Fua = Convert.ToDateTime(values[FUA]);
            }
        }

        private string GetFullErrorMessage(ModelStateDictionary modelState) {
            var messages = new List<string>();

            foreach(var entry in modelState) {
                foreach(var error in entry.Value.Errors)
                    messages.Add(error.ErrorMessage);
            }

            return String.Join(" ", messages);
        }
    }
}