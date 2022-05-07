using Core.Entities;
using Core.Repositories;
using Infrastructure.Data;
using Infrastructure.Repositories.Base;

namespace Infrastructure.Repositories
{
    public sealed class HotelPictureRepository : Repository<HotelPicture>,
        IHotelPictureRepository
    {
        public HotelPictureRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}