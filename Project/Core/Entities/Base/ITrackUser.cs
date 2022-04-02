namespace Core.Entities.Base
{
    public interface ITrackUser
    {
        public User CreatedBy { get; set; }
        public User ModifiedBy { get; set; }
    }
}