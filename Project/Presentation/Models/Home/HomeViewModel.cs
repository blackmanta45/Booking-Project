using System;
using System.ComponentModel.DataAnnotations;
using Core.Common.Enums;

namespace Presentation.Models.Home
{
    public class HomeViewModel
    {
        private string _dateFilter;

        [Required(ErrorMessage="Travel Period is required")]
        public string DateFilter
        {
            get => this._dateFilter;
            set
            {
                this._dateFilter = value;
                var dates = DateFilter.Split("-");
                StartDate = DateOnly.TryParse(dates[0], out var start) ? start : DateOnly.MinValue;
                EndDate = DateOnly.TryParse(dates[1], out var end) ? end : DateOnly.MinValue;
            }
        }

        public DateOnly StartDate { get; set; }

        public DateOnly EndDate { get; set; }

        [Required(ErrorMessage="Travel Location is required")]
        public string Location { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        [Required]
        public decimal Latitude { get; set; }
        [Required]
        public decimal Longitude { get; set; }

        [Required]
        public AvailableRoomSize People { get; set; }
    }
}