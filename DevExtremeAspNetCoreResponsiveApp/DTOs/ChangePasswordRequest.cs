﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevExtremeAspNetCoreResponsiveApp.DTOs
{
    public class ChangePasswordRequest
    {
        
        public string UserName { get; set; }
        [Required(ErrorMessage = "Debe ingresar su contraseña actual.")]
        [MinLength(8)]        
        public string currentpsw { get; set; }
        [Required(ErrorMessage = "Debe ingresar la nueva contraseña.")]
        [MinLength(8)]
        public string newpsw { get; set; }
        [Required(ErrorMessage = "Debe ingresar la confirmación de la contraseña.")]
        [MinLength(8)]
        [Compare("newpsw",ErrorMessage ="La nueva contraseña y la confirmación no coinciden.")]
        public string confirmnewpsw { get; set; }

    }
}