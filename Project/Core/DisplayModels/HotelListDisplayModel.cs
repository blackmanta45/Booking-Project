using System;

namespace Core.DisplayModels
{
    public class HotelListDisplayModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string Date { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Location { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Picture { get; set; }
        public int RoomsCount { get; set; }
    }
}