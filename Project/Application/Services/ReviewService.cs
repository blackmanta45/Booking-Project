using Core.Entities;
using Core.Repositories;
using Core.Services;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Http;

namespace Application.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IHotelRepository hotelRepository;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IReviewRepository reviewRepository;
        private readonly IUserRepository userRepository;

        public ReviewService(
            IReviewRepository reviewRepository,
            IHotelRepository hotelRepository,
            IHttpContextAccessor httpContextAccessor,
            IUserRepository userRepository)
        {
            this.reviewRepository = reviewRepository;
            this.hotelRepository = hotelRepository;
            this.httpContextAccessor = httpContextAccessor;
            this.userRepository = userRepository;
        }

        public async Task Add(
            string description,
            int value,
            Guid hotelId)
        {
            var hotel = await this.hotelRepository.GetHotelAsync(hotelId);
            var user = await this.userRepository.GetByIdAsync(Guid.Parse(this.httpContextAccessor.HttpContext.User.Identity.GetUserId()));

            if (user is null || hotel is null)
                return; 

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