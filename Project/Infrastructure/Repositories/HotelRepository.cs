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
            AvailableRoomSize people)
        {
            var hotels = await this.GetTable()
                .Include(x => x.Rooms)
                    .ThenInclude(y => y.Type)
                .Include(x => x.Occupations)
                    .ThenInclude(y => y.Room)
                .Include(x => x.Pictures)
                    .ThenInclude(y => y.Picture)
                .Where(z => !z.IsDeleted).ToListAsync();
            foreach (var hotel in hotels)
            {
                hotel.Rooms  = hotel.Rooms.Where(x => !hotel.Occupations.Where(y => y.Room == x).Any(y => y.Date >= startDate && y.Date <= endDate)).ToList();
            }

            hotels = hotels.Where(x => x.Rooms.Any()).ToList();
            return hotels;
        }
    }
}