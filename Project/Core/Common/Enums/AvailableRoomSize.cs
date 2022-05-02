using System.ComponentModel.DataAnnotations;

namespace Core.Common.Enums
{
    public enum AvailableRoomSize
    {
        [Display(Name = "1 Person")] Person1 = 1,
        [Display(Name = "2 Persons")] Person2 = 2,
        [Display(Name = "3 Persons")] Person3 = 3,
        [Display(Name = "4 Persons")] Person4 = 4,
        [Display(Name = "5 Persons")] Person5 = 5,
        [Display(Name = "6 Persons")] Person6 = 6,
    }
}