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
    public class Lotes1Controller : Controller
    {
        private PayLotsDBContext _context;

        public Lotes1Controller(PayLotsDBContext context) {
            this._context = context;
        }

        [HttpGet]
        public IActionResult Get(DataSourceLoadOptions loadOptions) {
            var lotes = _context.Lotes.Select(i => new {
                i.IdLote,
                i.IdBloque,
                i.NumeroLote,
                i.Area,
                i.Estado,
                i.Uar,
                i.Far,
                i.Uua,
                i.Fua
            });
            return Json(DataSourceLoader.Load(lotes, loadOptions));
        }

        [HttpPost]
        public IActionResult Post(string values) {
            var model = new Lotes();
            var _values = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, _values);

            if(!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));

            var result = _context.Lotes.Add(model);
            _context.SaveChanges();

            return Json(result.Entity.IdLote);
        }

        [HttpPut]
        public IActionResult Put(int key, string values) {
            var model = _context.Lotes.FirstOrDefault(item => item.IdLote == key);
            if(model == null)
                return StatusCode(409, "Lotes not found");

            var _values = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, _values);

            if(!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));

            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public void Delete(int key) {
            var model = _context.Lotes.FirstOrDefault(item => item.IdLote == key);

            _context.Lotes.Remove(model);
            _context.SaveChanges();
        }


        [HttpGet]
        public IActionResult BloquesLookup(DataSourceLoadOptions loadOptions) {
            var lookup = from i in _context.Bloques
                         orderby i.Bloque
                         select new {
                             Value = i.IdBloque,
                             Text = i.Bloque
                         };
            return Json(DataSourceLoader.Load(lookup, loadOptions));
        }

        private void PopulateModel(Lotes model, IDictionary values) {
            string ID_LOTE = nameof(Lotes.IdLote);
            string ID_BLOQUE = nameof(Lotes.IdBloque);
            string NUMERO_LOTE = nameof(Lotes.NumeroLote);
            string AREA = nameof(Lotes.Area);
            string ESTADO = nameof(Lotes.Estado);
            string UAR = nameof(Lotes.Uar);
            string FAR = nameof(Lotes.Far);
            string UUA = nameof(Lotes.Uua);
            string FUA = nameof(Lotes.Fua);

            if(values.Contains(ID_LOTE)) {
                model.IdLote = Convert.ToInt32(values[ID_LOTE]);
            }

            if(values.Contains(ID_BLOQUE)) {
                model.IdBloque = values[ID_BLOQUE] != null ? Convert.ToInt32(values[ID_BLOQUE]) : (int?)null;
            }

            if(values.Contains(NUMERO_LOTE)) {
                model.NumeroLote = Convert.ToString(values[NUMERO_LOTE]);
            }

            if(values.Contains(AREA)) {
                model.Area = values[AREA] != null ? Convert.ToDecimal(values[AREA], CultureInfo.InvariantCulture) : (decimal?)null;
            }

            if(values.Contains(ESTADO)) {
                model.Estado = Convert.ToString(values[ESTADO]);
            }

            if(values.Contains(UAR)) {
                model.Uar = Convert.ToString(values[UAR]);
            }

            if(values.Contains(FAR)) {
                model.Far = values[FAR] != null ? Convert.ToDateTime(values[FAR]) : (DateTime?)null;
            }

            if(values.Contains(UUA)) {
                model.Uua = Convert.ToString(values[UUA]);
            }

            if(values.Contains(FUA)) {
                model.Fua = values[FUA] != null ? Convert.ToDateTime(values[FUA]) : (DateTime?)null;
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