using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Common.Enums;
using Core.Entities;

namespace Core.Services
{
    public interface IHotelService
    {
        Task<List<Hotel>> GetFilteredHotels(
            DateTime startDate,
            DateTime endDate,
            decimal latitude,
            decimal longitude,
            AvailableRoomSize people);
    }
}