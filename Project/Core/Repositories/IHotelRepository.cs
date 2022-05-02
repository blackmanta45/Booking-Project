using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Common.Enums;
using Core.Entities;
using Core.Repositories.Base;

namespace Core.Repositories
{
    public interface IHotelRepository : IRepository<Hotel>
    {
        Task<List<Hotel>> GetFilteredAsync(
            DateTime startDate,
            DateTime endDate,
            AvailableRoomSize people);

        Task<Hotel> GetHotelAsync(Guid id);
    }
}