using System.Threading.Tasks;
using Core.Common.Enums;
using Core.Entities;

namespace Core.Services
{
    public interface IRoomService
    {
        Task AddRoomsForHotel(Hotel hotel, AvailableRoomSize people, int number);
    }
}