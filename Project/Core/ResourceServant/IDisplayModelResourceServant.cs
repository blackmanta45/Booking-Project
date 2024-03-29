﻿using System;
using Core.DisplayModels;
using Core.Entities;

namespace Core.ResourceServant
{
    public interface IDisplayModelResourceServant
    {
        HotelListDisplayModel ToListDisplayModel(
            Hotel hotel,
            string country,
            string city,
            DateTime start,
            DateTime end);

        HotelDetailsDisplayModel ToDetailsDisplayModel(Hotel hotel);
    }
}