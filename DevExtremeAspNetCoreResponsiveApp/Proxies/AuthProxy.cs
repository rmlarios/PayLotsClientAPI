using System.Threading.Tasks;
using System;
using DevExtremeAspNetCoreResponsiveApp.Proxies.Models;
using DevExtremeAspNetCoreResponsiveApp.Common;
using System.Net.Http;

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
      var response = await client.PostAsJsonAsync("Account/authenticate",model);

      response.EnsureSuccessStatusCode();

      return await response.Content.ReadAsAsync<Response<AuthenticationResponse>>();      
      
    }
  }
}
