using System.ComponentModel.DataAnnotations;
using MahalCoffee.Models;

namespace MahalCoffee_CSC400.Models;

public class Product
{
    public int ProductId { get; set; }

    [Required]
    public string? Name { get; set; }

    [Required]
    public string? ImageUrl { get; set; }

    [Required]
    public string? Description { get; set; }
    

    [Required]
    public double Price { get; set; }
    
  
    public int? BaristaId { get; set; }
    public Barista? Barista { get; set; }
    public int? MenuViewId { get; set; }
    public MenuView? MenuView { get; set; }
    public List<ProductIngredient>? ProductIngredients { get; set; }

    
}