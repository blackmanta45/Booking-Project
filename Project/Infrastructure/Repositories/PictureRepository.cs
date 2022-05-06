using Core.Entities;
using Core.Repositories;
using Infrastructure.Data;
using Infrastructure.Repositories.Base;

namespace Infrastructure.Repositories
{
    public sealed class PictureRepository : Repository<Picture>,
        IPictureRepository
    {
        public PictureRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}