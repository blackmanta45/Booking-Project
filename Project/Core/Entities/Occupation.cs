using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities.Base;

namespace Core.Entities
{
    [Table("Occupation")]
    public sealed class Occupation : BaseEntity,
        ITrackUser
    {
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public Room Room { get; set; }
    }
}