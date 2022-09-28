using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProject.Model;




namespace WebProject.Repository
{
    public interface IReviewsRepository
    {
        Task<List<ReviewModel>> GetAllReviewsAsync();
        Task<ReviewModel> GetReviewByIdAsync(int reviewId);
    }
}
