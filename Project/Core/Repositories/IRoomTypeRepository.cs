using System.Threading.Tasks;
using Core.Common.Enums;
using Core.Entities;
using Core.Repositories.Base;

namespace Core.Repositories
{
    public interface IRoomTypeRepository : IRepository<RoomType>
    {
        Task<RoomType> GetForSizeAndQuality(AvailableRoomSize people, int quality);
    }
}