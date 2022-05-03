using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Common.Enums;
using Microsoft.AspNetCore.Identity;

namespace Core.Entities
{
    [Table("User")]
    public class User : IdentityUser<Guid>
    {
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime ModifiedAt { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [MaxLength(10)]
        [MinLength(10)]
        public string Phone { get; set; }

        [Required]
        public Gender Gender { get; set; }

        public UserPicture Picture { get; set; }
        public List<History> History { get; set; }
        public List<Review> Reviews { get; set; }
    }
}