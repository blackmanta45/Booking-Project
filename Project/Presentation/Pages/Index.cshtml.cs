using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Presentation.Models.Home;

namespace Presentation.Pages.Home
{
    public class IndexPageModel : PageModel
    {
        [BindProperty]
        public IndexViewModel ViewModel { get; set; }
        
        public async Task<IActionResult> OnGetAsync()
        {
            return this.Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            //var a = this.ModelState;

            //var b = this.PageContext;

            return this.Page();
        }
    }
}