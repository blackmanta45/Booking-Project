using System.IO;
using System.Security.Claims;
using System.Threading.Tasks;
using Core.Entities;
using Core.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Presentation.Models.UserViewModels;

namespace Presentation.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> userManager;
        private readonly IPictureService pictureService;

        public RegisterModel(SignInManager<User> signInManager, UserManager<User> userManager,
            IPictureService pictureService)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.pictureService = pictureService;
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
                
                await this.userManager.AddClaimAsync(user, new Claim(ClaimTypes.Role, "basic"));

                if (result.Succeeded)
                {
                    await using (var memoryStream = new MemoryStream())
                    {
                        await this.Model.Picture.CopyToAsync(memoryStream);
                        await this.pictureService.AddUserPicture(user, memoryStream.ToArray());
                    }

                    await this.signInManager.SignInAsync(user, false);
                    return this.RedirectToPage("Profile");
                }
            }

            return this.Page();
        }
    }
}