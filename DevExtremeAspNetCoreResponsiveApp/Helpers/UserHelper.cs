using System.Security.Claims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtremeAspNetCoreResponsiveApp.Model;
using Microsoft.AspNetCore.Identity;

namespace DevExtremeAspNetCoreResponsiveApp.Helpers
{
  public class UserHelper : IUserHelper
  {
    private readonly UserManager<AppUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly SignInManager<AppUser> _signInManager;

    public UserHelper(
        UserManager<AppUser> userManager,
        RoleManager<IdentityRole> roleManager,
        SignInManager<AppUser> signInManager)
    {
      _userManager = userManager;
      _roleManager = roleManager;
      _signInManager = signInManager;
    }


    public async Task<AppUser> GetUserByEmailAsync(string email)
    {
      return await _userManager.FindByEmailAsync(email);
    }

    public async Task<AppUser> GetUserByNameAsync(string name)
    {
      return await _userManager.FindByNameAsync(name);
    }
    public async Task<IdentityResult> AddUserAsync(AppUser user, string password)
    {
      return await _userManager.CreateAsync(user, password);
    }

    public async Task AddUserToRoleAsync(AppUser user, string roleName)
    {
      await _userManager.AddToRoleAsync(user, roleName);
    }

    public async Task CheckRoleAsync(string roleName)
    {
      var roleExists = await _roleManager.RoleExistsAsync(roleName);
      if (!roleExists)
      {
        await _roleManager.CreateAsync(new IdentityRole
        {
          Name = roleName
        });
      }
    }

    public async Task<bool> IsUserInRoleAsync(AppUser user, string roleName)
    {
      return await _userManager.IsInRoleAsync(user, roleName);
    }

    public async Task SignInAsync(AppUser user, bool isPersistent)
    {
      await _signInManager.SignInAsync(user, isPersistent);
    }
    public async Task<SignInResult> LoginAsync(LoginView model)
    {

      return await _signInManager.PasswordSignInAsync(
          model.Username,
          model.Password,
          model.RememberMe,
          false);
    }

    public async Task AddUserClaims(AppUser user, IEnumerable<Claim> claims)
    {
      var claimsPrincipal = await _signInManager.CreateUserPrincipalAsync(user);
      var identity = claimsPrincipal.Identity as ClaimsIdentity;
      var claimslist = (from c in claimsPrincipal.Claims select c).ToList();
      foreach (var item in claimslist)
      {
         await _userManager.RemoveClaimAsync(user,item);         
        //identity.RemoveClaim(item);
      }

      var ident = await _userManager.AddClaimsAsync(user, claims);
    }

    public async Task LogoutAsync()
    {
      await _signInManager.SignOutAsync();
    }

    public async Task<string> GenerateEmailConfirmationTokenAsync(AppUser user)
    {
      return await _userManager.GenerateEmailConfirmationTokenAsync(user);
    }

    public async Task<bool> IsEmailConfirmedAsync(AppUser user)
    {
      return await _userManager.IsEmailConfirmedAsync(user);
    }

    public async Task<string> GeneratePasswordResetTokenAsync(AppUser user)
    {
      return await _userManager.GeneratePasswordResetTokenAsync(user);
    }



    /*
    public async Task<bool> DeleteUserAsync(string email)
    {
        var user = await GetUserByEmailAsync(email);
        if (user == null)
        {
            return true;
        }

        var response = await _userManager.DeleteAsync(user);
        return response.Succeeded;
    }

    public async Task<IdentityResult> UpdateUserAsync(AppUser user)
    {
        return await _userManager.UpdateAsync(user);
    }

    public async Task<SignInResult> ValidatePasswordAsync(AppUser user, string password)
    {
        return await _signInManager.CheckPasswordSignInAsync(
            user,
            password,
            false);
    }

    public async Task<IdentityResult> ChangePasswordAsync(AppUser user, string oldPassword, string newPassword)
    {
        return await _userManager.ChangePasswordAsync(user, oldPassword, newPassword);
    }

    public async Task<IdentityResult> ConfirmEmailAsync(AppUser user, string token)
    {
        return await _userManager.ConfirmEmailAsync(user, token);
    }



    public async Task<AppUser> GetUserByIdAsync(string userId)
    {
        return await _userManager.FindByIdAsync(userId);
    }

    public async Task<string> GeneratePasswordResetTokenAsync(AppUser user)
    {
        return await _userManager.GeneratePasswordResetTokenAsync(user);
    }

    public async Task<IdentityResult> ResetPasswordAsync(AppUser user, string token, string password)
    {
        return await _userManager.ResetPasswordAsync(user, token, password);
    }
    */


  }
}
