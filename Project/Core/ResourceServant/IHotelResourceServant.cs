using Core.DisplayModels;
using Core.Entities;

namespace Core.ResourceServant
{
    public interface IHotelResourceServant
    {
        HotelDisplayModel ToDisplayModel(
            Hotel hotel,
            string country,
            string city);
    }
}
