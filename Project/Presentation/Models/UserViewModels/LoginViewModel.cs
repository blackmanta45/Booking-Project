using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Presentation.Models.UserViewModels
{
    public class LoginViewModel
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Required]
        [PasswordPropertyText]
        public string Password { get; set; }
    }
}
