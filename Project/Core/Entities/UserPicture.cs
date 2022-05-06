using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities.Base;

namespace Core.Entities
{
    [Table("UserPicture")]
    public sealed class UserPicture : BaseEntityWithoutTracking
    {
        [Required]
        public Picture Picture { get; set; }
    }
}