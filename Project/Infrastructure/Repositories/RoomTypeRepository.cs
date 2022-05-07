using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Core.Common.Enums;
using Core.Entities;
using Core.Repositories;
using Infrastructure.Data;
using Infrastructure.Repositories.Base;

namespace Infrastructure.Repositories
{
    public sealed class RoomTypeRepository : Repository<RoomType>,
        IRoomTypeRepository
    {
        public RoomTypeRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<RoomType> GetForSizeAndQuality(AvailableRoomSize people, int quality) 
            => await this.GetTable().Where(x => x.People == people && x.Stars == quality).FirstOrDefaultAsync();
    }
}