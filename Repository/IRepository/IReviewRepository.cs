using MahalCoffee.Models;

namespace MahalCoffee.Repository.IRepository;

public interface IReviewRepository : IRepository<Review>
{
    Task UpdateAsync(Review review);
    
}