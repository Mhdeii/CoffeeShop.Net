using MahalCoffee_CSC400.Models;
using MahalCoffee.Models;

namespace MahalCoffee.Repository.IRepository;

public interface IProductRepository : IRepository<Product>
{
    Task UpdateAsync(Product product);
    
}

