using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HW22.Domain.Core.Dtos.User
{
    public class UpdateUserPasswordDto
    {
        [Required]
        public string CurrentPassword { get; set; }

        [Required]
        [MinLength(7, ErrorMessage = "Password must have at least 7 characters!")]
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
