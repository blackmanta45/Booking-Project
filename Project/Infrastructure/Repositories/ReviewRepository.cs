using Core.Entities;
using Core.Repositories;
using Infrastructure.Data;
using Infrastructure.Repositories.Base;

namespace Infrastructure.Repositories
{
    public sealed class ReviewRepository : Repository<Review>,
        IReviewRepository
    {
        public ReviewRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}