using System.ComponentModel.DataAnnotations;

namespace MahalCoffee.Models;

public class AppUser
{
    [Key]
    public int AppUserId { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string EmailAddress { get; set; }
    [Required]
    public string PhoneNumber { get; set; }
    [Required] 
    public string Password { get; set; }
}