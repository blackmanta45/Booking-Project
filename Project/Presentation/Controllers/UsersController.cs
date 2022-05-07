using System.Threading.Tasks;
using Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class UsersController : Controller
    {
        private readonly SignInManager<User> signInManager;

        public UsersController(SignInManager<User> signInManager)
        {
            this.signInManager = signInManager;
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await this.signInManager.SignOutAsync();

            return this.RedirectToPage("/Home/Index");
        }
    }
}