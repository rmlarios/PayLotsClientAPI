using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using DevExtremeAspNetCoreResponsiveApp.Common;
using DevExtremeAspNetCoreResponsiveApp.Proxies.Models;
using Newtonsoft.Json;
using System.Text;
using System.Collections;
using DevExtremeAspNetCoreResponsiveApp.Exceptions;

namespace DevExtremeAspNetCoreResponsiveApp.Proxies
{
  public interface IGenericProxy
  {
    Task<Response<T>> GetAsync<T>(string requestUrl) where T : class;
    Task<Response<T>> PostAsync<T>(string requestUrl, T model) where T : class;
  }
  public class GenericProxy : IGenericProxy
  {
    private readonly ProxyHttpClient _proxyHttpClient;

    public GenericProxy(ProxyHttpClient proxyHttpClient)
    {
      _proxyHttpClient = proxyHttpClient;
    }

    public async Task<Response<T>> GetAsync<T>(string requestUrl) where T : class
    {
      var _httpClient = _proxyHttpClient.Get();
      var response = _httpClient.GetAsync(requestUrl, HttpCompletionOption.ResponseHeadersRead).Result;
      //response.EnsureSuccessStatusCode();
      //var data = await response.Content.ReadAsAsync<Response<T>>()
      var data = await response.Content.ReadAsStringAsync();
      var Json = JsonConvert.DeserializeObject<Response<T>>(data);
      return Json;
      //return new Response<T>(data);
      //return JsonConvert.DeserializeObject<T>(data);
    }

    public async Task<Response<T>> PostAsync<T>(string requestUrl, T model) where T : class
    {
      var result = "";
      try
      {
        var _httpClient = _proxyHttpClient.Get();
        var Content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync(requestUrl, Content);
        //response.EnsureSuccessStatusCode();
        result = await response.Content.ReadAsStringAsync();
        var Json = JsonConvert.DeserializeObject<Response<T>>(result);
        return Json;

      }
      catch (Exception Ex)
      {
        return new Response<T>(Ex.Message);
      }
    }
  }
}
