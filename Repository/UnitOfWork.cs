using MahalCoffee.Data;
using MahalCoffee.Models;
using MahalCoffee.Repository.IRepository;
using MahalCoffee.Repsitory;

namespace MahalCoffee.Repository;
public class UnitOfWork : IUnitOfWork
{
   private AppDbContext _db;
   public IProductRepository Product { get; private set; }
   public IBaristaRepository Barista { get; private set; }
   public IReviewRepository Review { get; private set; }

   public UnitOfWork(AppDbContext db)
   {
      _db = db;
      Product = new ProductRepository(_db);
      Barista = new BaristaRepository(_db);
      Review = new ReviewRepository(_db);
   }

   public async Task SaveAsync()
   {
      await _db.SaveChangesAsync();
   }
}
