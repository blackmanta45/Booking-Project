using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Presentation.Pages.Utils
{
    public class TermsAndServicesModel : PageModel
    {
        public async Task<IActionResult> OnGetAsync()
        {
            return this.Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            return this.Page();
        }
    }
}
