using System;
using System.Net.Http;
using System.Threading.Tasks;
using DevExtremeAspNetCoreResponsiveApp.Common;
using DevExtremeAspNetCoreResponsiveApp.Proxies.Models;
using Newtonsoft.Json;

namespace DevExtremeAspNetCoreResponsiveApp.Proxies
{
  public interface IGenericProxy
  {
    Task<Response<T>> GetAsync<T>(string requestUrl) where T : class;
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
      var data = await response.Content.ReadAsAsync<Response<T>>();
      return data;
      //return JsonConvert.DeserializeObject<T>(data);
    }

   
  }
}
