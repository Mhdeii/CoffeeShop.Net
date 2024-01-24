using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MahalCoffee.Models;

public class ProductIngredients
{
    [Key]
    public int ProductIngredientsId { get; set; }
    
    [ForeignKey("ProductId")]
    public int ProductId { get; set; }
    [ForeignKey("IngredientsId")]
    public int IngredientsId { get; set; }
    
    public List<ProductIngredients> ProductIngredientsList { get; set; }
}