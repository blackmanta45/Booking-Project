
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Presentation.Models.UserViewModels;

namespace Presentation.Pages.UserPages
{
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> userManager;

        public RegisterModel(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        [BindProperty]
        public RegisterViewModel Model { get; set; } = new();

        public async Task<IActionResult> OnGetAsync() => this.Page();

        public async Task<IActionResult> OnPostAsync()
        {
            if (this.ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = this.Model.Username,
                    Email = this.Model.Email,
                    DateOfBirth = default,
                    Gender = this.Model.Gender,
                    Name = this.Model.Name,
                    Surname = this.Model.Surname,
                    Phone = this.Model.Phone
                };
                var result = await this.userManager.CreateAsync(user, this.Model.Password);

                if (result.Succeeded)
                    await this.signInManager.SignInAsync(user, false);
            }

            return this.Page();
        }
    }
}