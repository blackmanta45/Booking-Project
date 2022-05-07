using System.IO;
using System.Threading.Tasks;
using Core.Common.Enums;
using Core.Entities;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Presentation.Models.Hotel;

namespace Presentation.Pages.Hotels
{
    public class AddHotelModel : PageModel
    {
        private readonly IHotelService hotelService;
        private readonly IRoomService roomService;
        private readonly IPictureService pictureService;

        public AddHotelModel(IHotelService hotelService, IRoomService roomService,
            IPictureService pictureService)
        {
            this.hotelService = hotelService;
            this.roomService = roomService;
            this.pictureService = pictureService;
        }

        [BindProperty]
        public AddHotelViewModel Model { get; set; } = new();
        
        public async Task<IActionResult> OnGetAsync()
        {
            return this.Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (this.ModelState.IsValid)
            {
                var hotel = new Hotel
                {
                    Name = Model.Name,
                    Description = Model.Description,
                    ShortDescription = Model.ShortDescription,
                    Latitude = Model.Latitude,
                    Longitude = Model.Longitude,
                    Quality = Model.Quality
                };
                var dbHotel = await this.hotelService.AddHotel(hotel);
                await this.roomService.AddRoomsForHotel(dbHotel, AvailableRoomSize.Person1, Model.OnePersonRooms);
                await this.roomService.AddRoomsForHotel(dbHotel, AvailableRoomSize.Person2, Model.TwoPersonRooms);
                await this.roomService.AddRoomsForHotel(dbHotel, AvailableRoomSize.Person3, Model.ThreePersonRooms);
                await this.roomService.AddRoomsForHotel(dbHotel, AvailableRoomSize.Person4, Model.FourPersonRooms);
                await this.roomService.AddRoomsForHotel(dbHotel, AvailableRoomSize.Person5, Model.FivePersonRooms);
                await this.roomService.AddRoomsForHotel(dbHotel, AvailableRoomSize.Person6, Model.SixPersonRooms);

                foreach (var picture in Model.Picture)
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
