using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.ViewModel
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage ="Username is required")]
        [StringLength(15, MinimumLength =5, ErrorMessage = "Username must be between 5 and 15")]
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 20")]
        
        public string Password { get; set; }

        [Required(ErrorMessage = "Verification of password is required.")]
        [Compare("Password", ErrorMessage = "Password must match")]
        public string VerifyPassword { get; set; }
    }
}
