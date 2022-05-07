using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Presentation.Models.Hotel
{
    public class AddHotelViewModel
    {
        [Required]
        [StringLength(20, ErrorMessage = "Your hotel's name cannot be longer than 20 characters.")]
        public string Name { get; set; }

        [Required]
        [StringLength(800)]
        public string Description { get; set; }

        [Required]
        [StringLength(200)]
        public string ShortDescription { get; set; }

        [Required]
        public decimal Latitude { get; set; }

        [Required]
        public decimal Longitude { get; set; }

        public string Location { get; set; }

        [Required]
        [Range(1, 5)]
        public int Quality { get; set; }

        [Required]
        [Range(0, 20)]
        public int OnePersonRooms { get; set; }

        [Required]
        [Range(0, 20)]
        public int TwoPersonRooms { get; set; }

        [Required]
        [Range(0, 20)]
        public int ThreePersonRooms { get; set; }

        [Required]
        [Range(0, 20)]
        public int FourPersonRooms { get; set; }

        [Required]
        [Range(0, 20)]
        public int FivePersonRooms { get; set; }

        [Required]
        [Range(0, 20)]
        public int SixPersonRooms { get; set; }

        [Required]
        public IList<IFormFile> Picture { get; set; }
    }
}