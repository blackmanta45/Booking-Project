using Core.DisplayModels;
using Core.Entities;
using Core.ResourceServant;

namespace Application.ResourceServant
{
    public class HotelResourceServant : IHotelResourceServant
    {
        public HotelDisplayModel ToDisplayModel(
            Hotel hotel,
            string country,
            string city) =>
            new()
            {
                Id = hotel.Id,
                Name = hotel.Name,
                Description = hotel.Description,
                ShortDescription = hotel.ShortDescription,
                Latitude = hotel.Latitude,
                Longitude = hotel.Longitude,
                Location = $"{country}, {city}",
                City = city,
                Country = country,
                Picture = ToPicture(hotel)
            };

        private static string ToPicture(Hotel hotel)
        {
            var img = hotel.Pictures.FirstOrDefault()?.Picture.Bytes;
            if (img != null)
            {
                var imageBase64Data = Convert.ToBase64String(img);
                return string.Format($"data:image/jpg;base64,{imageBase64Data}");
                
            }

            return null;
        }
    }
}