using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MahalCoffee_CSC400.Models;

namespace MahalCoffee.Models;

public class Barista 
{
    [Key]
    public int BaristaId { get; set; }
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string EmailAddress { get; set; }
    [Required]
    public string PhoneNumber { get; set; }
    [Required] 
    public string Password { get; set; }
    
    public int? AdminId { get; set; }
    public Admin? Admin { get; set; }
    public List<Product> Products { get; set; }
}