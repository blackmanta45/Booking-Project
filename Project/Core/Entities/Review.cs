using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities.Base;

namespace Core.Entities
{
    [Table("Review")]
    public sealed class Review : BaseEntityWithoutTracking
    {
        [Range(1, 5)]
        public int Value { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }
        
        [Required]
        public DateTime Date { get; set; }
        
        [Required]
        public Hotel Hotel { get; set; }
        
        [Required]
        public User User { get; set; }
    }
}