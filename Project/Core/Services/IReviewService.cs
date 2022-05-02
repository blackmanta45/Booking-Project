using System;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IReviewService
    {
        Task Add(
            string description,
            int value,
            Guid hotelId);
    }
}