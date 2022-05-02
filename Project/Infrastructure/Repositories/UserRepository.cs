using Core.Entities;
using Core.Repositories;
using Infrastructure.Data;
using Infrastructure.Repositories.Base;

namespace Infrastructure.Repositories
{
    public sealed class UserRepository : Repository<User>,
        IUserRepository
    {
        public UserRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}