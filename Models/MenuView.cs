using MahalCoffee_CSC400.Models;

namespace MahalCoffee.Models;

public class MenuView
{
    public int MenuViewId { get; set; }

    public string Name { get; set; }
    public List<Product> Products { get; set; }
}
