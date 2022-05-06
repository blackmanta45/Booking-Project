using Core.Entities;
using Core.Repositories;
using Infrastructure.Data;
using Infrastructure.Repositories.Base;

namespace Infrastructure.Repositories
{
    public sealed class UserPictureRepository : Repository<UserPicture>,
        IUserPictureRepository
    {
        public UserPictureRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}