using MahalCoffee.Models;

namespace MahalCoffee.Repository.IRepository;

public interface IMenuViewRepository : IRepository<MenuView>
{
    Task UpdateAsync(MenuView menuView);

}