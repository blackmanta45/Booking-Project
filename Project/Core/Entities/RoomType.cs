﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Common.Enums;
using Core.Entities.Base;

namespace Core.Entities
{
    [Table("RoomType")]
    public sealed class RoomType : IHaveId
    {
        public AvailableRoomSize People { get; set; }
        public decimal DefaultPrice { get; set; }

        [Range(1, 5)]
        public int Stars { get; set; }

        [Key]
        [Required]
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}