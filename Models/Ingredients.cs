using System.ComponentModel.DataAnnotations;

namespace MahalCoffee.Models;

public class Ingredients
{
    [Key]
    public int IngredientsId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    public List<ProductIngredient> ProductIngredients { get; set; }
}