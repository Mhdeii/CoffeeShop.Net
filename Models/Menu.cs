using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MahalCoffee_CSC400.Models;

namespace MahalCoffee.Models;

public class Menu
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MenuId { get; set; }

    public string Name { get; set; }

    
    public List<Product> Products { get; set; }
}