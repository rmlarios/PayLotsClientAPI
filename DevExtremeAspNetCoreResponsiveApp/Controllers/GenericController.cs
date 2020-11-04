using System;
using System.Threading.Tasks;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using NToastNotify;

namespace DevExtremeAspNetCoreResponsiveApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenericController<T> : ControllerBase where T : class, new()
    {
        private readonly IGenericProxy _genericProxy;
        private readonly IToastNotification _toastNotification;
        private readonly string _ClassName;
        private readonly string _GetAllUrl;
        private readonly string _GetbyIdUrl;



        public GenericController(IGenericProxy genericProxy, IToastNotification toastNotification, string ClassName, string GetAllUrl, string GetbyIdUrl)
        {
            _genericProxy = genericProxy;
            _toastNotification = toastNotification;
            _ClassName = ClassName;
            _GetAllUrl = GetAllUrl;
            _GetbyIdUrl = GetbyIdUrl;
        }

        [HttpGet("Listar")]
        public async Task<IActionResult> GetAll(DataSourceLoadOptions loadOptions)
        {
            var result = await _genericProxy.GetAsync<T>(_ClassName + _GetAllUrl);
            return new JsonResult(DataSourceLoader.Load(result.Datas, loadOptions));
        }

        [HttpGet]
        public async Task<IActionResult> GetbyId(int id, DataSourceLoadOptions loadOptions)
        {
            var result = await _genericProxy.GetAsync<T>(_ClassName + _GetbyIdUrl + id);
            return new JsonResult(DataSourceLoader.Load(result.Datas, loadOptions));
        }

        [HttpPost]
        public async Task<IActionResult> PostCreate([FromForm] string values)
        {
            T entity = new T();
            JsonConvert.PopulateObject(values, entity);
            var result = await _genericProxy.PostAsync<T>(_ClassName + "Create", entity);
            if (result.Succeeded)
            {
                _toastNotification.AddSuccessToastMessage(result.Message);
                return new OkObjectResult(result.Message);
            }
            else
            {
                _toastNotification.AddErrorToastMessage(result.Message);
                return BadRequest(result.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> PutUpdate([FromForm] int key, [FromForm] string values)
        {
            var current = await _genericProxy.GetAsync<T>(_ClassName + key);
            T entity = new T();
            entity = current.Data;
            JsonConvert.PopulateObject(values, entity);
            //bloque.IdBloque = key;      
            var result = await _genericProxy.PutAsync<T>(_ClassName + key, entity);
            if (result.Succeeded)
            {
                _toastNotification.AddSuccessToastMessage(result.Message);
                return new OkObjectResult(result.Message);
            }
            else
            {
                _toastNotification.AddErrorToastMessage(result.Message);
                return BadRequest(result.Message);
            }
        }
        [HttpDelete]
        public async Task<IActionResult> DeletebyId([FromForm] int key)
        {
            var result = await _genericProxy.DeleteAsync(_ClassName + key);
            if (result.Succeeded)
            {
                _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                {
                });
                return new OkObjectResult(result.Message);
            }
            else
            {
                _toastNotification.AddErrorToastMessage(result.Message);
                return BadRequest(result.Message);
            }
        }





    }
}
