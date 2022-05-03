using Core.Entities;
using Core.Repositories;
using Core.Services;

namespace Application.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IHotelRepository hotelRepository;
        private readonly IReviewRepository reviewRepository;
        private readonly IUserRepository userRepository;

        public ReviewService(
            IReviewRepository reviewRepository,
            IHotelRepository hotelRepository,
            IUserRepository userRepository)
        {
            this.reviewRepository = reviewRepository;
            this.hotelRepository = hotelRepository;
            this.userRepository = userRepository;
        }

        public async Task Add(
            string description,
            int value,
            Guid hotelId)
        {
            var hotel = await this.hotelRepository.GetHotelAsync(hotelId);
            var user = await this.userRepository.GetByIdAsync(Guid.Parse("AC365E29-7F22-472F-BD22-CE7FAB2E48F2"));
            var review = new Review
            {
                Value = value,
                Description = description,
                Date = DateTime.Now,
                Hotel = hotel,
                User = user
            };
            await this.reviewRepository.AddAsync(review);
        }
    }
}