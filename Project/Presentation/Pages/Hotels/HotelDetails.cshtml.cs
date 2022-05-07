using System;
using System.Threading.Tasks;
using Core.Common.Enums;
using Core.DisplayModels;
using Core.Entities;
using Core.ResourceServant;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Presentation.Pages.Hotels
{
    public class HotelDetailsModel : PageModel
    {
        private readonly IDisplayModelResourceServant displayModelResourceServant;
        private readonly IHotelService hotelService;
        private readonly IReviewService reviewService;

        public HotelDetailsModel(
            IHotelService hotelService,
            IDisplayModelResourceServant displayModelResourceServant,
            IReviewService reviewService)
        {
            this.hotelService = hotelService;
            this.displayModelResourceServant = displayModelResourceServant;
            this.reviewService = reviewService;
        }

        public Hotel Hotel { get; set; }
        public HotelDetailsDisplayModel HotelDetailsDisplayModel { get; set; }
        public AvailableRoomSize People { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public async Task<IActionResult> OnGetAsync(
            Guid id,
            AvailableRoomSize people,
            DateTime startDate,
            DateTime endDate)
        {
            this.Start = startDate;
            this.End = endDate;
            this.People = people;
            this.Hotel = await this.hotelService.GetHotelDetails(id, people);

            if (this.Hotel is null)
                return this.RedirectToPage("/Home/Index");

            this.HotelDetailsDisplayModel = this.displayModelResourceServant.ToDetailsDisplayModel(this.Hotel);
            return this.Page();
        }

        public async Task<IActionResult> OnPostReserveAsync(
            Guid hotelId,
            AvailableRoomSize people,
            DateTime start,
            DateTime end)
        {
            var hotel = await this.hotelService.GetHotelDetails(hotelId, people);
            if (hotel != null)
                await this.hotelService.Reserve(hotel, people, start, end);
            return this.RedirectToPage("/home/index");
        }

        public PartialViewResult OnPostAddReview() =>
            new()
            {
                ViewName = "AddReviewModal",
                ViewData = new ViewDataDictionary<Review>(this.ViewData, new Review
                {
                    Description = "",
                    Value = 1
                })
            };

        public async Task<IActionResult> OnPostAddReviewSubmit(
            string description,
            int rating,
            string hotelId,
            AvailableRoomSize people,
            DateTime startDate,
            DateTime endDate)
        {
            await this.reviewService.Add(description, rating, Guid.Parse(hotelId));
            this.Start = startDate;
            this.End = endDate;
            this.People = people;
            this.Hotel = await this.hotelService.GetHotelDetails(Guid.Parse(hotelId), people);

            if (this.Hotel is null)
                return this.RedirectToPage("/Home/Index");

            this.HotelDetailsDisplayModel = this.displayModelResourceServant.ToDetailsDisplayModel(this.Hotel);

            return this.Page();
        }
    }
}