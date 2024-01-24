using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MahalCoffee_CSC400.Models;

namespace MahalCoffee.Models;

public class ProductIngredient
{
    [Key]
    public int ProductIngredientsId { get; set; }
    
   
    public int ProductId { get; set; }
    public Product Product { get; set; }
    
    public int IngredientsId { get; set; }
    public Ingredients ingredients { get; set; }
    
    
    public List<ProductIngredient> ProductIngredients { get; set; }
}