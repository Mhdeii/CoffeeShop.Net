using MahalCoffee.Models;

namespace MahalCoffee.Repository.IRepository;

public interface IBaristaRepository : IRepository<Barista>
{
    Task UpdateAsync(Barista barista);
}