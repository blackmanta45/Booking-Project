using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Common.Enums;
using Core.Entities.Base;

namespace Core.Entities
{
    [Table("User")]
    public class User : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

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