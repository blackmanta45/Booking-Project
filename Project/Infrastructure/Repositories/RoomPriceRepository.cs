using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Repositories;
using Infrastructure.Data;
using Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public sealed class RoomPriceRepository : Repository<RoomPrice>,
        IRoomPriceRepository
    {
        public RoomPriceRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<RoomPrice>> GetAllForRoom(Room room) => await this.GetQuery(x => x.Room == room).ToListAsync();
    }
}