using System.IO;
using System.Threading.Tasks;
using Core.Common.Enums;
using Core.Entities;
using Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Presentation.Models.Hotel;

namespace Presentation.Pages.Hotels
{
    [Authorize(Policy = "AdminOnly")]
    public class AddHotelModel : PageModel
    {
        private readonly IHotelService hotelService;
        private readonly IPictureService pictureService;
        private readonly IRoomService roomService;

        public AddHotelModel(
            IHotelService hotelService,
            IRoomService roomService,
            IPictureService pictureService)
        {
            this.hotelService = hotelService;
            this.roomService = roomService;
            this.pictureService = pictureService;
        }

        [BindProperty]
        public AddHotelViewModel Model { get; set; } = new();

        public async Task<IActionResult> OnGetAsync() => this.Page();

        public async Task<IActionResult> OnPostAsync()
        {
            if (this.ModelState.IsValid)
            {
                var hotel = new Hotel
                {
                    Name = this.Model.Name,
                    Description = this.Model.Description,
                    ShortDescription = this.Model.ShortDescription,
                    Latitude = this.Model.Latitude,
                    Longitude = this.Model.Longitude,
                    Quality = this.Model.Quality
                };
                var dbHotel = await this.hotelService.AddHotel(hotel);
                await this.roomService.AddRoomsForHotel(dbHotel, AvailableRoomSize.Person1, this.Model.OnePersonRooms);
                await this.roomService.AddRoomsForHotel(dbHotel, AvailableRoomSize.Person2, this.Model.TwoPersonRooms);
                await this.roomService.AddRoomsForHotel(dbHotel, AvailableRoomSize.Person3, this.Model.ThreePersonRooms);
                await this.roomService.AddRoomsForHotel(dbHotel, AvailableRoomSize.Person4, this.Model.FourPersonRooms);
                await this.roomService.AddRoomsForHotel(dbHotel, AvailableRoomSize.Person5, this.Model.FivePersonRooms);
                await this.roomService.AddRoomsForHotel(dbHotel, AvailableRoomSize.Person6, this.Model.SixPersonRooms);

                foreach (var picture in this.Model.Picture)
                {
                    await using var memoryStream = new MemoryStream();
                    await picture.CopyToAsync(memoryStream);
                    await this.pictureService.AddHotelPicture(dbHotel, memoryStream.ToArray());
                }
            }

            return this.RedirectToPage("/home/index");
        }
    }
}