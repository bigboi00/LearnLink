using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace FineBlog.ViewModels
{
    public class LoginVM
    {
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required.")]
        public string? Username { get; set; }
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required.")]
        public string? Password { get; set; }
        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
