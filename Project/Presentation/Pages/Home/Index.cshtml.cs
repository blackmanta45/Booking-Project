﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Presentation.Models.Home;

namespace Presentation.Pages.Home
{
    public class IndexPageModel : PageModel
    {
        [BindProperty]
        public HomeViewModel ViewModel { get; set; } = new();

        public async Task<IActionResult> OnGetAsync() => this.Page();

        public async Task<IActionResult> OnPostAsync()
        {
            if (this.ModelState.IsValid)
            {
                return this.RedirectToPage("../Hotels/HotelList", new
                {
                    this.ViewModel.StartDate,
                    this.ViewModel.EndDate,
                    this.ViewModel.Latitude,
                    this.ViewModel.Longitude,
                    this.ViewModel.City,
                    this.ViewModel.Country,
                    this.ViewModel.People
                });
            }

            return this.Page();
        }
    }
}