using Core.Entities;
using Core.Repositories;
using Core.Services;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Http;

namespace Application.Services
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IUserRepository userRepository;

        public UserService(
            IHttpContextAccessor httpContextAccessor,
            IUserRepository userRepository)
        {
            this.httpContextAccessor = httpContextAccessor;
            this.userRepository = userRepository;
        }

        public async Task<User> GetCurrentUser() => await this.userRepository.GetByIdAsync(Guid.Parse(this.httpContextAccessor.HttpContext.User.Identity.GetUserId()));
    }
}