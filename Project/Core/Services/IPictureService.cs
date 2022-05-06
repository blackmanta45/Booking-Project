using System.Threading.Tasks;
using Core.Entities;

namespace Core.Services
{
    public interface IPictureService
    {
        Task AddUserPicture(User user, byte[] picture);
    }
}