using Core.Entities;
using Core.Repositories;
using Core.Services;

namespace Application.Services
{
    public class PictureService : IPictureService
    {
        private readonly IPictureRepository pictureRepository;
        private readonly IUserPictureRepository userPictureRepository;
        private readonly IUserRepository userRepository;

        public PictureService(IPictureRepository pictureRepository, IUserPictureRepository userPictureRepository,
            IUserRepository userRepository)
        {
            this.pictureRepository = pictureRepository;
            this.userPictureRepository = userPictureRepository;
            this.userRepository = userRepository;
        }

        public async Task AddUserPicture(User user, byte[] picture)
        {
            if (user.Picture is not null)
            {
                var userPicture = user.Picture;
                var pictureDb = user.Picture.Picture;
                user.Picture = null;
                await this.userRepository.UpdateAsync(user);
                await this.userPictureRepository.DeleteAsync(userPicture);
                await this.pictureRepository.DeleteAsync(pictureDb);
            }

            var dbPicture = await this.pictureRepository.AddAsync(new Picture {Bytes = picture});
            var dbUserPicture = await this.userPictureRepository.AddAsync(new UserPicture {Picture = dbPicture});
            user.Picture = dbUserPicture;
            await this.userRepository.UpdateAsync(user);
        }
    }
}