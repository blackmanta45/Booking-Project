using Core.DisplayModels;
using Core.Entities;
using Core.ResourceServant;

namespace Application.ResourceServant
{
    public class HotelResourceServant : IHotelResourceServant
    {
        public HotelListDisplayModel ToListDisplayModel(
            Hotel hotel,
            string country,
            string city,
            DateTime start,
            DateTime end) =>
            new()
            {
                Id = hotel.Id,
                Name = hotel.Name,
                Description = hotel.Description,
                ShortDescription = hotel.ShortDescription,
                Date = $"{start:dd/MM/yyyy} - {end:dd/MM/yyyy}",
                Latitude = hotel.Latitude,
                Longitude = hotel.Longitude,
                Location = $"{country}, {city}",
                City = city,
                Country = country,
                Picture = ToPicture(hotel.Pictures.FirstOrDefault()?.Picture)
            };

        public HotelDetailsDisplayModel ToDetailsDisplayModel(Hotel hotel)
        {
            var enjoyPercentage = hotel.Reviews.Count > 0 ? hotel.Reviews.Count(x => x.Value > 3) * 1.0 / hotel.Reviews.Count(x => x.Value <= 3) * 100 : 0;
            return new()
            {
                Id = hotel.Id,
                Name = hotel.Name,
                Description = hotel.Description,
                Price = hotel.Rooms.First().Type.DefaultPrice,
                Rating = hotel.Quality,
                EnjoyPercentage = Convert.ToInt32(enjoyPercentage),
                Pictures = hotel.Pictures.Select(x => ToPicture(x.Picture)).ToList(),
                Reviews = hotel.Reviews.Select(ToReviewDisplayModel).ToList()
            };
        }

        private static ReviewDisplayModel ToReviewDisplayModel(Review review) =>
            new()
            {
                Id = review.Id,
                Value = review.Value,
                Description = review.Description,
                Date = review.Date,
                User = ToUserDisplayModel(review.User)
            };

        private static UserDisplayModel ToUserDisplayModel(User user) =>
            new()
            {
                Id = user.Id,
                Name = user.Name + " " + user.Surname,
                Picture = ToPicture(user.Picture?.Picture)
            };

        private static string? ToPicture(Picture? picture)
        {
            if (picture is null) 
                return null;

            var imageBase64Data = Convert.ToBase64String(picture.Bytes);
            return string.Format($"data:image/jpg;base64,{imageBase64Data}");
        }
    }
}