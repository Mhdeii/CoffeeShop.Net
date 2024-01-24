using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MahalCoffee.Models;

public class Review
{
    
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ReviewId { get; set; }

    public string Comment { get; set; }

    public int Rating { get; set; } 
    public int? CustomerId { get; set; }
    public Customer? Customer { get; set; }
    /*public string ImageUrl { get; set; }*/
}