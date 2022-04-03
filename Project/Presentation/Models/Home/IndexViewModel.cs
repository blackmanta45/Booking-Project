using System;
using Core.Common.Enums;

namespace Presentation.Models.Home
{
    public class IndexViewModel
    {
        public DateOnly Start { get; set; }
        public DateOnly End { get; set; }

        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public AvailableRoomSize People { get; set; }
    }
}