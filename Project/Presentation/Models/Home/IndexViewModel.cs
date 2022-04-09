using System.ComponentModel.DataAnnotations;
using Core.Common.Enums;

namespace Presentation.Models.Home
{
    public class IndexViewModel
    {
        public string DateFilter { get; set; }

        public string Location { get; set; }

        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public AvailableRoomSize People { get; set; }
    }
}