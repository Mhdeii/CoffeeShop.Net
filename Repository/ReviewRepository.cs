using System.Linq.Expressions;
using MahalCoffee_CSC400.Models;
using MahalCoffee.Data;
using MahalCoffee.Models;
using MahalCoffee.Repository.IRepository;
using MahalCoffee.Repsitory;


namespace MahalCoffee.Repsitory;

public class ReviewRepository : Repository<Review>, IReviewRepository
{
    private AppDbContext _db;

    public ReviewRepository(AppDbContext db) : base(db)
    {
        _db = db;
    }

    public async Task UpdateAsync(Review review)
    {
        _db.Reviews.Update(review);
        await _db.SaveChangesAsync();
    }


    
}