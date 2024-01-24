using System.ComponentModel.DataAnnotations;

namespace MahalCoffee.Models;

public class Admin 
{
 [Key]   
 public int AdminId { get; set; }
 public string FirstName { get; set; }
 [Required]
 public string LastName { get; set; }
 [Required]
 public string EmailAddress { get; set; }
 [Required]
 public string PhoneNumber { get; set; }
 [Required] 
 public string Password { get; set; }
 public List<Barista> Baristas { get; set; }

}