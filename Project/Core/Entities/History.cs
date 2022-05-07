using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities.Base;

namespace Core.Entities
{
    [Table("History")]
    public class History : BaseEntityWithoutTracking
    {
        [Required]
        public decimal Price { get; set; }

        [Required]
        public int People { get; set; }

        [Required]
        public Hotel Hotel { get; set; }

        [Required]
        public User User { get; set; }

        [Required]

        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }
    }
}