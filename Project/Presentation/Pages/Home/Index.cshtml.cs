using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Presentation.Models.Home;

namespace Presentation.Pages.Home
{
    public class IndexPageModel : PageModel
    {
        [BindProperty]
        public HomeViewModel ViewModel { get; set; } = new();
        
        public async Task<IActionResult> OnGetAsync()
        {
            return this.Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (this.ModelState.IsValid)
            {
                return this.RedirectToPage("../HotelList/HotelListIndex", new {ViewModel.StartDate, ViewModel.EndDate, ViewModel.Latitude, ViewModel.Longitude, ViewModel.City, ViewModel.Country, ViewModel.People});
                //return this.RedirectToPage($"/HotelList/HotelListIndex/{ViewModel.StartDate}/{ViewModel.EndDate}/{ViewModel.Latitude}/{ViewModel.Longitude}/{ViewModel.City}/{ViewModel.Country}/{ViewModel.People}");
            }

            return this.Page();
        }
    }
}