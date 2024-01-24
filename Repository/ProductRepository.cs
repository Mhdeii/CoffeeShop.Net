using System.Linq.Expressions;
using MahalCoffee_CSC400.Models;
using MahalCoffee.Data;
using MahalCoffee.Models;
using MahalCoffee.Repository.IRepository;
using MahalCoffee.Repsitory;


namespace MahalCoffee.Repsitory;

public class ProductRepository : Repository<Product>, IProductRepository
{
    private AppDbContext _db;

    public ProductRepository(AppDbContext db) : base(db)
    {
        _db = db;
    }

    public async Task UpdateAsync(Product product)
    {
        _db.Products.Update(product);
        await _db.SaveChangesAsync();
    }

  
}