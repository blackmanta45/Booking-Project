using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using Core.Common.Enums;

namespace Presentation.Models.Home
{
    public sealed class HomeViewModel
    {
        private string _dateFilter;
        private decimal latitude;
        private decimal longitude;

        [Required(ErrorMessage = "Travel Period is required")]
        public string DateFilter
        {
            get => this._dateFilter;
            set
            {
                this._dateFilter = value;
                var dates = this.DateFilter.Split(" - ");
                this.StartDate = Convert.ToDateTime(dates[0], CultureInfo.GetCultureInfo("en-US").DateTimeFormat);
                this.EndDate = Convert.ToDateTime(dates[1], CultureInfo.GetCultureInfo("en-US").DateTimeFormat);
            }
        }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Travel Location is required")]
        public string Location { get; set; }

        public string City { get; set; }
        public string Country { get; set; }

        [Required]
        public decimal Latitude
        {
            get => this.latitude;
            set
            {
                var str = value.ToString(CultureInfo.InvariantCulture);
                var index = str.IndexOf(".", StringComparison.Ordinal);
                var val = index == -1 ? str.Insert(2, ".") : str.Remove(index, 1).Insert(2, ".");
                this.latitude = decimal.TryParse(val, out var number) ? number : decimal.Zero;
            }
        }

        [Required]
        public decimal Longitude
        {
            get => this.longitude;
            set
            {
                var str = value.ToString(CultureInfo.InvariantCulture);
                var index = str.IndexOf(".", StringComparison.Ordinal);
                var val = index == -1 ? str.Insert(2, ".") : str.Remove(index, 1).Insert(2, ".");
                this.longitude = decimal.TryParse(val, out var number) ? number : decimal.Zero;
            }
        }

        [Required]
        public AvailableRoomSize People { get; set; }
    }
}