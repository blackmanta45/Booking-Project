using System;
using System.ComponentModel.DataAnnotations;
using Core.Common.Enums;

namespace Presentation.Models.Home
{
    public sealed class HomeViewModel
    {
        private string _dateFilter;

        [Required(ErrorMessage="Travel Period is required")]
        public string DateFilter
        {
            get => this._dateFilter;
            set
            {
                this._dateFilter = value;
                var dates = DateFilter.Split(" - ");
                StartDate = DateTime.TryParse(dates[0], out var start) ? start : DateTime.MinValue;
                EndDate = DateTime.TryParse(dates[1], out var end) ? end : DateTime.MinValue;
            }
        }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

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