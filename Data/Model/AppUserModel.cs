using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Model
{
    public class AppUserModel
    {
        public string Id { get; set; }
        public bool IsActive { get; set; } = false;
        [Required]
        public string UserName { get; set; }
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }

        public string Rol { get; set; } = "";
    }
}
