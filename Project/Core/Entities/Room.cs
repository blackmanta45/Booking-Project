using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities.Base;

namespace Core.Entities
{
    [Table("Room")]
    public sealed class Room : BaseEntity, ITrackUser
    {
        [Range(1, int.MaxValue)]
        public int Amount { get; set; }

        [Required]
        public RoomType Type { get; set; }
        
        [Required]
        public Hotel Hotel { get; set; }

        public User CreatedBy { get; set; }
        public User ModifiedBy { get; set; }
    }
}