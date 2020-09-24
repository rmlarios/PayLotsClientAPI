using System.Linq.Expressions;
using System.Security.Claims;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using DevExtremeAspNetCoreResponsiveApp.Model;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using DevExtremeAspNetCoreResponsiveApp.Helpers;
using DevExtremeAspNetCoreResponsiveApp.Proxies;
using DevExtremeAspNetCoreResponsiveApp.Proxies.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;

namespace DevExtremeAspNetCoreResponsiveApp.Areas.Identity.Pages.Account
{
  [AllowAnonymous]
  public class LoginModel : PageModel
  {
    private readonly SignInManager<AppUser> _signInManager;
    private readonly ILogger<LoginModel> _logger;
    private readonly IUserHelper _userHelper;
    private readonly IAuthProxy _authProxy;

    public LoginModel(SignInManager<AppUser> signInManager, ILogger<LoginModel> logger, IUserHelper userHelper, IAuthProxy authProxy)
    {
      _signInManager = signInManager;
      _logger = logger;
      _userHelper = userHelper;
      _authProxy = authProxy;
    }

    //[BindProperty]
    //public InputModel Input { get; set; }

    [BindProperty]
    public LoginView Input { get; set; }

    public IList<AuthenticationScheme> ExternalLogins { get; set; }

    public string ReturnUrl { get; set; }

    [TempData]
    public string ErrorMessage { get; set; }

    public class InputModel
    {
      [Required]
      [EmailAddress]
      public string Email { get; set; }

      [Required]
      [DataType(DataType.Password)]
      public string Password { get; set; }

      [Display(Name = "Remember me?")]
      public bool RememberMe { get; set; }
    }

    public async Task OnGetAsync(string returnUrl = null)
    {
      if (!string.IsNullOrEmpty(ErrorMessage))
      {
        ModelState.AddModelError(string.Empty, ErrorMessage);
      }

      returnUrl = returnUrl ?? Url.Content("~/");

      // Clear the existing external cookie to ensure a clean login process
      await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
     

      ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

      ReturnUrl = returnUrl;
    }

    [HttpPost]
    public async Task<IActionResult> OnPostAsync(string returnUrl = null)
    {
      returnUrl = returnUrl ?? Url.Content("~/");
      LoginAuthModel model = new LoginAuthModel();
      model.Email = Input.Username;
      model.Password = Input.Password;

      var result = await _authProxy.Authenticate(model);
      if (result.Succeeded)
      {
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier,result.Data.Id),
            new Claim(ClaimTypes.Email,result.Data.Email),
            new Claim("access_token",result.Data.JWToken),
        };

        var user = await _userHelper.GetUserByNameAsync(model.Email);
        await _userHelper.AddUserClaims(user,claims);        
        await _userHelper.SignInAsync(user,false);

        /* var claimsIdentity = new ClaimsIdentity(claims,IdentityConstants.ApplicationScheme);

        await HttpContext.SignInAsync(IdentityConstants.ApplicationScheme,new ClaimsPrincipal(claimsIdentity),new AuthenticationProperties{
            AllowRefresh = true,
            IsPersistent=true              
        }); */

                
        return Redirect("~/");
      }



      /*
                  if (ModelState.IsValid)
                  {
                      // This doesn't count login failures towards account lockout
                      // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                      //var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: true);
                      var result = await _userHelper.LoginAsync(Input);
                      if (result.Succeeded)
                      {
                          _logger.LogInformation("User logged in.");
                          return LocalRedirect(returnUrl);
                      }
                      if (result.RequiresTwoFactor)
                      {
                          return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                      }
                      if (result.IsLockedOut)
                      {
                          _logger.LogWarning("User account locked out.");
                          return RedirectToPage("./Lockout");
                      }
                      else
                      {
                          ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                          return Page();
                      }
                  }
      */
      // If we got this far, something failed, redisplay form
      return Page();
    }
  }
}
