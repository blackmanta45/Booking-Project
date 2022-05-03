using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Base
{
    public interface IBaseEntity
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}