using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace DevExtremeAspNetCoreResponsiveApp.Common
{
  public class ProxyHttpClient
  {
    private readonly IConfiguration _configuration;
    private readonly IHttpContextAccessor _httpContextAccesor;

    public ProxyHttpClient(IConfiguration configuration,IHttpContextAccessor httpContextAccessor)
    {
      _configuration = configuration;
      _httpContextAccesor = httpContextAccessor;
    }

    public HttpClient Get()
    {
      var client = new HttpClient();
      client.BaseAddress = new Uri(_configuration.GetValue<string>($"APIs:url"));
      client.DefaultRequestHeaders
      .Accept
      .Add(new MediaTypeWithQualityHeaderValue("application/json"));

      if(_httpContextAccesor.HttpContext.User != null && _httpContextAccesor.HttpContext.User.Identity.IsAuthenticated)
      {
          var claims = _httpContextAccesor.HttpContext.User.Claims;
          var access_token = claims.FirstOrDefault(x => x.Type.Equals("access_token")).Value;
          client.DefaultRequestHeaders.Add("Authorization",$"Bearer {access_token}");
      }

      return client;

    }

  }
}
