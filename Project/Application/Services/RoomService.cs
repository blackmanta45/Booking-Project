using Core.Common.Enums;
using Core.Entities;
using Core.Repositories;
using Core.Services;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Http;

namespace Application.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository roomRepository;
        private readonly IRoomTypeRepository roomTypeRepository;

        public RoomService(IRoomRepository roomRepository, IRoomTypeRepository roomTypeRepository)
        {
            this.roomRepository = roomRepository;
            this.roomTypeRepository = roomTypeRepository;
        }

        public async Task AddRoomsForHotel(
            Hotel hotel,
            AvailableRoomSize people,
            int number)
        {
            var roomType = await this.roomTypeRepository.GetForSizeAndQuality(people, hotel.Quality);
            for (var i = 0; i < number; i++)
            {
                var room = new Room
                {
                    Amount = 3,
                    Type = roomType,
                    Hotel = hotel
                };
                await this.roomRepository.AddAsync(room);
            }
        }
    }
}