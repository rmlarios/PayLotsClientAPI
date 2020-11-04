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
using System.Net;

namespace DevExtremeAspNetCoreResponsiveApp.Proxies
{
  public interface IGenericProxy
  {
    Task<Response<string>> DeleteAsync(string requestUrl);
    Task<Response<T>> GetAsync<T>(string requestUrl) where T : class;
    Task<Response<T>> PostAsync<T>(string requestUrl, T model) where T : class;
    Task<Response<T>> PutAsync<T>(string requestUrl, T model) where T : class;
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
      if (response.StatusCode != HttpStatusCode.BadRequest && response.StatusCode != HttpStatusCode.OK)
      {
        return new Response<T>(response.StatusCode.ToString(), false);
      }
      else
      {
        var data = await response.Content.ReadAsStringAsync();
        var Json = JsonConvert.DeserializeObject<Response<T>>(data);
        return Json;
      }

    }

    public async Task<Response<T>> PostAsync<T>(string requestUrl, T model) where T : class
    {
      var result = "";
      try
      {
        var _httpClient = _proxyHttpClient.Get();
        var Content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync(requestUrl, Content);
        if (response.StatusCode != HttpStatusCode.BadRequest && response.StatusCode != HttpStatusCode.OK)
        {
          return new Response<T>(response.StatusCode.ToString(), false);
        }
        else
        {
          result = await response.Content.ReadAsStringAsync();
          var Json = JsonConvert.DeserializeObject<Response<T>>(result);
          return Json;
        }
      }
      catch (Exception Ex)
      {
        return new Response<T>(Ex.Message);
      }
    }

    public async Task<Response<T>> PutAsync<T>(string requestUrl, T model) where T : class
    {
      try
      {
        var _httpClient = _proxyHttpClient.Get();
        var Content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
        var response = await _httpClient.PutAsync(requestUrl, Content);
        if (response.StatusCode != HttpStatusCode.BadRequest && response.StatusCode != HttpStatusCode.OK)
        {
          return new Response<T>(response.StatusCode.ToString(), false);
        }
        else
        {
          var result = await response.Content.ReadAsStringAsync();
          var Json = JsonConvert.DeserializeObject<Response<T>>(result);
          return Json;
        }

      }
      catch (Exception Ex)
      {
        return new Response<T>(Ex.Message);
      }
    }

    public async Task<Response<string>> DeleteAsync(string requestUrl)
    {
      var _httpClient = _proxyHttpClient.Get();
      var response = await _httpClient.DeleteAsync(requestUrl);
      if (response.StatusCode != HttpStatusCode.BadRequest && response.StatusCode != HttpStatusCode.OK)
      {
        return new Response<string>(response.StatusCode.ToString(), false);
      }
      else
      {
        var result = await response.Content.ReadAsStringAsync();
        var resp = JsonConvert.DeserializeObject<Response<string>>(result);
        return new Response<string>(resp.Message, resp.Succeeded);
      }
    }


  }
}
