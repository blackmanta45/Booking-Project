using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Base
{
    public class BaseEntityWithoutTracking
    {
        [Key]
        [Required]
        public Guid Id { get; set; } = Guid.NewGuid();

        public bool IsDeleted { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}