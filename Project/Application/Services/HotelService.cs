using Core.Common.Enums;
using Core.Entities;
using Core.Repositories;
using Core.Services;

namespace Application.Services
{
    public class HotelService : IHotelService
    {
        private readonly IHotelRepository hotelRepository;

        public HotelService(IHotelRepository hotelRepository)
        {
            this.hotelRepository = hotelRepository;
        }

        public async Task<List<Hotel>> GetFilteredHotels(
            DateTime startDate,
            DateTime endDate,
            decimal latitude,
            decimal longitude,
            AvailableRoomSize people)
        {
            var hotels = await this.hotelRepository.GetFilteredAsync(
                startDate,
                endDate,
                people);

            return hotels.Where(x => this.Calculate(
                (double)latitude,
                (double)longitude,
                (double)x.Latitude,
                (double)x.Longitude) <= 15).ToList();
        }

        private double Calculate(
            double lat1,
            double lon1,
            double lat2,
            double lon2)
        {
            double rad(double angle)
            {
                return angle * 0.017453292519943295769236907684886127d;
            } // = angle * Math.Pi / 180.0d

            double havf(double diff)
            {
                return Math.Pow(Math.Sin(rad(diff) / 2d), 2);
            } // = sin²(diff / 2)

            return 12745.6 * Math.Asin(Math.Sqrt(havf(lat2 - lat1) + (Math.Cos(rad(lat1)) * Math.Cos(rad(lat2)) * havf(lon2 - lon1)))); // earth radius 6.372,8‬km x 2 = 12745.6
        }
    }
}