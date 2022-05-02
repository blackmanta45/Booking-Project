using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Common.Enums;
using Core.DisplayModels;
using Core.ResourceServant;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Presentation.Pages.HotelList
{
    public class HotelListIndexModel : PageModel
    {
        private readonly IHotelResourceServant hotelResourceServant;
        private readonly IHotelService hotelService;

        public HotelListIndexModel(IHotelService hotelService, IHotelResourceServant hotelResourceServant)
        {
            this.hotelService = hotelService;
            this.hotelResourceServant = hotelResourceServant;
        }

        public string City { get; set; }
        public string Country { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public AvailableRoomSize People { get; set; }
        public List<HotelListDisplayModel> Hotels { get; set; }

        public async Task<IActionResult> OnGetAsync(
            DateTime startDate,
            DateTime endDate,
            decimal latitude,
            decimal longitude,
            string city,
            string country,
            AvailableRoomSize people)
        {
            this.City = city;
            this.Country = country;
            this.Start = startDate;
            this.End = endDate;
            this.People = people;

            if (string.IsNullOrEmpty(this.City) || string.IsNullOrEmpty(this.Country))
                return this.RedirectToPage("/Home/Index");

            var hotels = await this.hotelService.GetFilteredHotels(
                startDate,
                endDate,
                latitude,
                longitude,
                people);

            this.Hotels = hotels.Select(x => this.hotelResourceServant.ToListDisplayModel(x, this.Country, this.City, this.Start, this.End)).ToList();
            return this.Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (this.ModelState.IsValid)
            {
                return this.RedirectToPage("");
            }

            return this.Page();
        }
    }
}