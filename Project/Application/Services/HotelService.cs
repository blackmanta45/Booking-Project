using Core.Common.Enums;
using Core.Entities;
using Core.Repositories;
using Core.Services;

namespace Application.Services
{
    public class HotelService : IHotelService
    {
        private readonly IHotelRepository hotelRepository;
        private readonly IOccupationRepository occupationRepository;

        public HotelService(
            IHotelRepository hotelRepository,
            IOccupationRepository occupationRepository)
        {
            this.hotelRepository = hotelRepository;
            this.occupationRepository = occupationRepository;
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

        public async Task<Hotel> GetHotelDetails(
            Guid id,
            AvailableRoomSize people)
        {
            var hotel = await this.hotelRepository.GetHotelAsync(id);
            hotel.Rooms = hotel.Rooms.Where(x => x.Type.People == people).ToList();
            hotel.Reviews = hotel.Reviews.OrderByDescending(x => x.Date).ToList();
            return hotel;
        }

        public async Task Reserve(
            Hotel hotel,
            AvailableRoomSize people,
            DateTime start,
            DateTime end)
        {
            end = end.AddHours(1);
            var occupations = await this.occupationRepository.GetOccupationsForHotelAndPeriod(hotel, people, start, end);
            var room = hotel.Rooms.FirstOrDefault(x => occupations.All(y => y.Room != x));
            while (start < end)
            {
                await this.occupationRepository.Reserve(room, start);
                start = start.AddDays(1);
            }
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