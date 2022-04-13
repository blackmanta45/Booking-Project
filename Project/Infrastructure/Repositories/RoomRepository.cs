using Core.Entities;
using Core.Repositories;
using Infrastructure.Data;
using Infrastructure.Repositories.Base;

namespace Infrastructure.Repositories
{
    public sealed class RoomRepository : Repository<Room>,
        IRoomRepository
    {
        public RoomRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}