﻿using System;
using Core.Entities;

namespace Core.DisplayModels
{
    public class HotelDisplayModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Location { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Picture { get; set; }
    }
}