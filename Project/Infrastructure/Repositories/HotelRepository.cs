using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Common.Enums;
using Core.Entities;
using Core.Repositories;
using Infrastructure.Data;
using Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public sealed class HotelRepository : Repository<Hotel>,
        IHotelRepository
    {
        public HotelRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Hotel>> GetFilteredAsync(
            DateTime startDate,
            DateTime endDate,
            AvailableRoomSize people) =>
            await this.GetTable()
                .Include(x => x.Rooms)
                .ThenInclude(y => y.Type)
                .Include(x => x.Pictures)
                .ThenInclude(y => y.Picture)
                .Where(z => !z.IsDeleted).ToListAsync();

        public async Task<Hotel> GetHotelAsync(Guid id)
        {
            var hotel = await this.GetTable()
                .Include(x => x.Rooms)
                .ThenInclude(y => y.Type)
                .Include(x => x.Pictures)
                .ThenInclude(y => y.Picture)
                .Include(x => x.Reviews)
                .ThenInclude(y => y.User)
                .ThenInclude(z => z.Picture)
                .ThenInclude(t => t.Picture)
                .Where(z => z.Id == id).FirstOrDefaultAsync();
            return hotel;
        }
    }
}