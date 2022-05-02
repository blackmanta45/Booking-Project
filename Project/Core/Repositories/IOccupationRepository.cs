using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Common.Enums;
using Core.Entities;
using Core.Repositories.Base;

namespace Core.Repositories
{
    public interface IOccupationRepository : IRepository<Occupation>
    {
        Task Reserve(
            Room room,
            DateTime date);

        Task<List<Occupation>> GetOccupationsForHotelAndPeriod(
            Hotel hotel,
            AvailableRoomSize people,
            DateTime start,
            DateTime end);
    }
}