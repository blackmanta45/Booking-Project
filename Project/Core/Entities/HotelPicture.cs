using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities.Base;

namespace Core.Entities
{
    [Table("HotelPicture")]
    public sealed class HotelPicture : BaseEntity
    {
        [Required]
        public Picture Picture { get; set; }

        [Required]
        public Hotel Hotel { get; set; }
    }
}