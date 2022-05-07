using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Repositories.Base;

namespace Core.Repositories
{
    public interface IRoomPriceRepository : IRepository<RoomPrice>
    {
        Task<List<RoomPrice>> GetAllForRoom(Room room);
    }
}