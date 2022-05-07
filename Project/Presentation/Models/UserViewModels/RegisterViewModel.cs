using System.ComponentModel.DataAnnotations;
using Core.Common.Enums;
using Microsoft.AspNetCore.Http;

namespace Presentation.Models.UserViewModels
{
    public class RegisterViewModel
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "YOUR USERNAME MUST BE BETWEEN 8 AND 20 CHARACTERS!!!!!!")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$", ErrorMessage = "Make your password stronger!")]
        [StringLength(18, ErrorMessage = "The password must be at least 8 characters long.", MinimumLength = 8)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$", ErrorMessage = "Make your password stronger!")]
        [StringLength(18, ErrorMessage = "The password must be at least 8 characters long.", MinimumLength = 8)]
        public string RepeatedPassword { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        [MaxLength(10)]
        [MinLength(10)]
        public string Phone { get; set; }

        [Required]
        public IFormFile Picture { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "Passwords must match!")]
        public bool PasswordsMatch => this.RepeatedPassword == this.Password;
    }
}