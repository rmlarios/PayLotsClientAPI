using System.Threading.Tasks;
using System.Text;
using DevExtremeAspNetCoreResponsiveApp.Proxies.Models;
using DevExtremeAspNetCoreResponsiveApp.Common;
using System.Net.Http;
using Newtonsoft.Json;

namespace DevExtremeAspNetCoreResponsiveApp.Proxies
{
  public interface IAuthProxy
  {
      Task<Response<AuthenticationResponse>> Authenticate(LoginAuthModel model);
  }

  public class AuthProxy : IAuthProxy
  {
    private readonly ProxyHttpClient _proxyHttpClient;

    public AuthProxy(ProxyHttpClient proxyHttpClient)
    {
        _proxyHttpClient = proxyHttpClient;
    }
    public async Task<Response<AuthenticationResponse>> Authenticate(LoginAuthModel model)
    {
      var client = _proxyHttpClient.Get();
      var Content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
      var response = await client.PostAsync("Account/authenticate",Content);
      //response.EnsureSuccessStatusCode();
      var result = await response.Content.ReadAsStringAsync();
      var Json = JsonConvert.DeserializeObject<Response<AuthenticationResponse>>(result);   
      return Json;
      
    }
  }
}
