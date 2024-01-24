using MahalCoffee_CSC400.Models;
using MahalCoffee.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace MahalCoffee.Data;

public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Product> Products{ get; set; } 
    
    public DbSet<Barista> Baristas{ get; set; }
    public DbSet<Ingredients> Ingredients { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<MenuView> MenuViews { get; set; }
    public DbSet<Admin> Admins { get; set; }
    public DbSet<ProductIngredient> ProductIngredients { get; set; }
    


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Admin>().HasData(
            new Admin()
            {
                AdminId = 1,
                FirstName = "Alaa",
                LastName = "Harake",
                EmailAddress = "alaadiabelharake@gmail.com",
                Password = "123456",
                PhoneNumber = "76878216",
               
                
            }
        );
        modelBuilder.Entity<Barista>().HasData(
            new Barista
            {
                BaristaId = 1,
                FirstName = "Hasan",
                LastName = "Ha",
                EmailAddress = "hasandiabelharake@gmail.com",
                PhoneNumber = "12334556",
                Password = "Has123san456",
                AdminId = 1,
                
            }
        );
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                ProductId = 1,
                Name = "Mocha Frappe",
                Description =
                    "Savor the rich harmony of espresso, chocolate syrup, milk, and ice in our Mocha Frappuccino.",
                ImageUrl = "/images/menu-4.png",
                Price = 8.89,
                BaristaId = 1,
                

            },
          
            new Product
            {
                ProductId = 2,
                Name = "Caramel Frappe",
                Description =
                    "Indulge in the sweet elegance of espresso, caramel syrup, milk, and whipped cream in our" +
                    " Caramel Frappuccino.",
                ImageUrl = "https://th.bing.com/th?id=OIP.zO6PWxvBseZ4vqXTAhAHaQHaLH&w=204&h=306&c=8&rs=1&qlt=90&o=6&dpr=1.3&pid=3.1&rm=2",
                Price = 9.5,
                MenuViewId = 1,
                BaristaId = 1

            }
        );
      
       
        modelBuilder.Entity<Customer>().HasData(
            new Customer
            {
                CustomerId = 1,
                FirstName = "Alaa",
                LastName = "Diab El Harake",
                EmailAddress = "alaadiabelharake@gmail.com",
                PhoneNumber = "7687826",
                Password = "alaa10122003",
               
               
            }
        );
        modelBuilder.Entity<Review>().HasData(
            new Review()
            {
                ReviewId = 1,
                Comment = "Best Coffee i have ever taste",
                Rating = 5,
                CustomerId = 1
            });
        modelBuilder.Entity<Ingredients>().HasData(
            new Ingredients()
            {
                IngredientsId = 1,
                Name = "MahalCoffee",
                Description = "Best Coffee i have ever taste",
            });
        modelBuilder.Entity<ProductIngredient>().HasData(
            new ProductIngredient()
            {
               ProductId = 1,
               IngredientsId = 1
            });
       
        modelBuilder.Entity<MenuView>().HasData(
            new MenuView()
            {
              MenuViewId = 1,
              Name = "MahalCoffee"
            });
        modelBuilder.Entity<ProductIngredient>()
            .HasKey(pi => new { pi.ProductId, pi.IngredientsId });

        modelBuilder.Entity<ProductIngredient>()
            .HasOne(pi => pi.Product)
            .WithMany(p => p.ProductIngredients)
            .HasForeignKey(pi => pi.ProductId);

        modelBuilder.Entity<ProductIngredient>()
            .HasOne(pi => pi.ingredients)
            .WithMany(i => i.ProductIngredients)
            .HasForeignKey(pi => pi.IngredientsId);
        modelBuilder.Entity<Product>()
            .HasOne(pi => pi.Barista)
            .WithMany(i => i.Products)
            .HasForeignKey(pi => pi.BaristaId);
        modelBuilder.Entity<Review>()
            .HasOne(pi => pi.Customer)
            .WithMany(i => i.Reviews)
            .HasForeignKey(pi => pi.CustomerId);
        modelBuilder.Entity<Product>()
            .HasOne(pi => pi.MenuView)
            .WithMany(i => i.Products)
            .HasForeignKey(pi => pi.MenuViewId);
        modelBuilder.Entity<Barista>()
            .HasOne(pi => pi.Admin)
            .WithMany(i => i.Baristas)
            .HasForeignKey(pi => pi.AdminId);
    }
    
}




