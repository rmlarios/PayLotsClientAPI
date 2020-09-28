using DevExtremeAspNetCoreResponsiveApp.Model;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DevExtremeAspNetCoreResponsiveApp.Helpers
{
    public interface IUserHelper
    {
        Task<AppUser> GetUserByNameAsync(string name);
        Task<AppUser> GetUserByEmailAsync(string email);
        Task<bool> IsEmailConfirmedAsync(AppUser user);
        Task<IdentityResult> AddUserAsync(AppUser User, string password);
        Task CheckRoleAsync(string roleName);
        Task AddUserToRoleAsync(AppUser User, string roleName);
        Task<bool> IsUserInRoleAsync(AppUser user, string roleName);
        Task<SignInResult> LoginAsync(LoginView model);
        Task LogoutAsync();
        Task<string> GeneratePasswordResetTokenAsync(AppUser user);
        Task<string> GenerateEmailConfirmationTokenAsync(AppUser user);
        Task SignInAsync(AppUser user, bool isPersistent);
        Task AddUserClaims(AppUser user, IEnumerable<Claim> claims);
  }
}
