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
    public sealed class OccupationRepository : Repository<Occupation>,
        IOccupationRepository
    {
        public OccupationRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task Reserve(
            Room room,
            DateTime date)
        {
            var occupation = new Occupation
            {
                Date = date,
                Room = room,
                Hotel = room.Hotel
            };
            await this.AddAsync(occupation);
        }

        public async Task<List<Occupation>> GetOccupationsForHotelAndPeriod(
            Hotel hotel,
            AvailableRoomSize people,
            DateTime start,
            DateTime end) =>
            await this.GetTable()
                .Include(x => x.Room)
                    .ThenInclude(y => y.Hotel)
                .Include(x => x.Room)
                    .ThenInclude(y => y.Type)
                .Where(x => x.Room.Hotel == hotel && x.Date <= end && x.Date >= start && x.Room.Type.People == people)
                .ToListAsync();
    }
}