using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Base
{
    public interface IHaveId
    {
        [Key]
        public Guid Id { get; set; }
    }
}