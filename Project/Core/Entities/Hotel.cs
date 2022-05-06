using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities.Base;

namespace Core.Entities
{
    [Table("Hotel")]
    public sealed class Hotel : BaseEntity, ITrackUser
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [StringLength(200)]
        public string ShortDescription { get; set; }

        [Required]
        public decimal Latitude { get; set; }

        [Required]
        public decimal Longitude { get; set; }

        [Range(1, 5)]
        public int Quality { get; set; }
        public ICollection<HotelPicture> Pictures { get; set; }
        public ICollection<Room> Rooms { get; set; }
        public ICollection<History> History { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}