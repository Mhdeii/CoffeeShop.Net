using MahalCoffee.Data;
using MahalCoffee.Models;
using MahalCoffee.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using MahalCoffee.Repsitory;

namespace MahalCoffee.Repository;

public class BaristaRepository : Repository<Barista>, IBaristaRepository
{
    private AppDbContext _db;

    public BaristaRepository(AppDbContext db) : base(db)
    {
        _db = db;
    }

    public async Task UpdateAsync(Barista barista)
    {
        _db.Baristas.Update(barista);
        await _db.SaveChangesAsync();
    }
}