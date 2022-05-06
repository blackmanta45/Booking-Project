using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities.Base;

namespace Core.Entities
{
    [Table("Picture")]
    public sealed class Picture : BaseEntity, ITrackUser
    {
        [Required]
        public byte[] Bytes { get; set; }
    }
}