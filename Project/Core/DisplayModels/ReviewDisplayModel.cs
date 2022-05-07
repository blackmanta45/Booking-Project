using System;

namespace Core.DisplayModels
{
    public class ReviewDisplayModel
    {
        public Guid Id { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }

        public DateTime Date { get; set; }
        public UserDisplayModel User { get; set; }
    }
}