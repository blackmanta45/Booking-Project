using System.Threading.Tasks;
using Core.Entities;

namespace Core.Services
{
    public interface IUserService
    {
        Task<User> GetCurrentUser();
    }
}