using System;
using System.Collections.Generic;

namespace Core.DisplayModels
{
    public class HotelDetailsDisplayModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public int Rating { get; set; }
        public int EnjoyPercentage { get; set; }
        public ICollection<string> Pictures { get; set; }
        public ICollection<ReviewDisplayModel> Reviews { get; set; }
    }
}