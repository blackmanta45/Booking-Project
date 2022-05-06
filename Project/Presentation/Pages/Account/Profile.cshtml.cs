using System.IO;
using System.Threading.Tasks;
using Core.Entities;
using Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Presentation.Models.UserViewModels;

namespace Presentation.Pages.Account
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        private readonly IPictureService pictureService;
        private readonly UserManager<User> userManager;
        private readonly IUserService userService;

        public ProfileModel(
            IPictureService pictureService,
            IUserService userService,
            UserManager<User> userManager)
        {
            this.pictureService = pictureService;
            this.userService = userService;
            this.userManager = userManager;
        }

        [BindProperty]
        public ProfileViewModel Model { get; set; } = new();

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await this.userService.GetCurrentUser();

            this.Model.Gender = user.Gender;
            this.Model.Name = user.Name;
            this.Model.Surname = user.Surname;
            this.Model.Username = user.UserName;
            this.Model.Phone = user.Phone;
            this.Model.Email = user.Email;

            return this.Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (this.ModelState.IsValid)
            {
                var user = await this.userService.GetCurrentUser();
                if (this.Model.Picture is not null)
                {
                    await using var memoryStream = new MemoryStream();
                    await this.Model.Picture.CopyToAsync(memoryStream);
                    await this.pictureService.AddUserPicture(user, memoryStream.ToArray());
                }

                user.Gender = this.Model.Gender;
                user.Name = this.Model.Name;
                user.Surname = this.Model.Surname;
                user.UserName = this.Model.Username;
                user.Phone = this.Model.Phone;
                user.Email = this.Model.Email;

                await this.userManager.UpdateAsync(user);
                var token = await this.userManager.GeneratePasswordResetTokenAsync(user);
                await this.userManager.ResetPasswordAsync(user, token, this.Model.Password);
            }

            return this.Page();
        }
    }
}