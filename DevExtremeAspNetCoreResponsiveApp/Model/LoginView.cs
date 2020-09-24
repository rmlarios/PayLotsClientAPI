using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevExtremeAspNetCoreResponsiveApp.Model
{
    public class LoginView
    {
        [Required]
        [Display(Name ="Usuario")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Contraseña")]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }

    }
}
