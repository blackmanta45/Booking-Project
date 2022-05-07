using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities.Base;

namespace Core.Entities
{
    [Table("RoomPrice")]
    public sealed class RoomPrice : BaseEntity,
        ITrackUser
    {
        [Required]
        public Room Room { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}