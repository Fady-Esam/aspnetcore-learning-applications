﻿using System.ComponentModel.DataAnnotations;

namespace AuthProject.Helpers
{
    public class LogInModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
