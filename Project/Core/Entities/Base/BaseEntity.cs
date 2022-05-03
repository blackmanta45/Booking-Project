using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Base
{
    public class BaseEntity : IBaseEntity
    {
        [Key]
        [Required]
        public Guid Id { get; set; } = Guid.NewGuid();

        public bool IsDeleted { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime ModifiedAt { get; set; }
    }
}