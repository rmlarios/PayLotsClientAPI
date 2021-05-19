using System.Threading.Tasks;
using Data.Model;
using DevExtremeAspNetCoreResponsiveApp.DTOs;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NToastNotify;
using System.Web;
using Microsoft.AspNetCore.Http;
using DevExtreme.AspNet.Mvc;
using DevExtreme.AspNet.Data;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace DevExtremeAspNetCoreResponsiveApp.Controllers
{
    public class AsignacionesController : GenericController<ViewAsignacionesSaldo>
    {
        IToastNotification _toastNotification;

        public class ActivarRequest
        {
            public string IdAsignacion { get; set; }
        }

      

        class Filters
        {
            public string Field { get; set; }
            public string Condition { get; set; }
            public string Value { get; set; }
        }

        public AsignacionesController(IGenericProxy genericProxy, IToastNotification toastNotification) : base(genericProxy, toastNotification, "Asignacion/", "GetAsignaciones", "GetbyBenef/")
        {
            _toastNotification = toastNotification;
        }

        [HttpPost]
        public async Task<IActionResult> Anular([FromForm] AnularAsignacionRequest values)
        {
            string url = Request.GetTypedHeaders().Referer.ToString();

            //JsonConvert.PopulateObject(values, entity);
            var result = await _genericProxy.PostAsync<AnularAsignacionRequest>("Asignacion/Anular", values);
            if (result.Succeeded)
            {
                _toastNotification.AddSuccessToastMessage(result.Message);
                return Ok(values.IdAsignacion);
                //TempData["Msg"] = "Uploaded successfully";        
                //return new OkObjectResult(result.Message);
            }
            else
            {
                _toastNotification.AddErrorToastMessage(result.Message);
                return BadRequest(error: result.Message);
                //TempData["Msg"] = "Uploaded error"; 
                //return BadRequest(result.Message);
            }
            //return Redirect(url);
            //return LocalRedirect("~/Asignacion/Listado");
            //return View();
        }

        [HttpPost]
        public async Task<IActionResult> Activar([FromForm] string IdAsignacion)
        {
            //    Beneficiarios entity = new Beneficiarios();
            //  JsonConvert.PopulateObject(values, entity);
            ActivarRequest request = new ActivarRequest();
            request.IdAsignacion = IdAsignacion;
            var result = await _genericProxy.PostAsync<ActivarRequest>("Asignacion/Activar", request);
            if (result.Succeeded)
            {
                _toastNotification.AddSuccessToastMessage(result.Message);
                return Ok(IdAsignacion);
                //return new OkObjectResult(result.Message);
            }
            else
            {
                _toastNotification.AddErrorToastMessage(result.Message);
                return BadRequest(error: result.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAsignaciones(DataSourceLoadOptions loadOptions, int id = 0)
        {
            string busqueda = "";
            Filters filters = new Filters();
            if (loadOptions.Filter != null)
                if (loadOptions.Filter.Count != 0)
                    if (loadOptions.Filter[0].ToString() != "IdAsignacion")
                        if (JArray.FromObject(loadOptions.Filter[0])[0].ToString() == "NombreLote")
                            busqueda = JArray.FromObject(loadOptions.Filter[0])[2].ToString();

            var result = await _genericProxy.GetAsync<ViewAsignacionesSaldo>("Asignacion/GetAsignacionesForm/" + id);
            
                        //filters = JsonConvert.DeserializeObject<Filters>(loadOptions.Filter[0].ToString());
                        //            JArray r = JArray.Parse(loadOptions.Filter[0].ToString());
            if (result.Succeeded == true)
                return new JsonResult(DataSourceLoader.Load(result.Datas, loadOptions));

            return new JsonResult(DataSourceLoader.Load(new List<ViewAsignacionesSaldo>(), new DataSourceLoadOptionsBase()));
        }
    }
}