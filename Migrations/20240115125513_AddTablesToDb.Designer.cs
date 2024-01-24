﻿// <auto-generated />
using System;
using MahalCoffee.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MahalCoffee_CSC400.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240115125513_AddTablesToDb")]
    partial class AddTablesToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MahalCoffee.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            AdminId = 1,
                            EmailAddress = "alaadiabelharake@gmail.com",
                            FirstName = "Alaa",
                            LastName = "Harake",
                            Password = "123456",
                            PhoneNumber = "76878216"
                        });
                });

            modelBuilder.Entity("MahalCoffee.Models.Barista", b =>
                {
                    b.Property<int>("BaristaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BaristaId"));

                    b.Property<int?>("AdminId")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BaristaId");

                    b.HasIndex("AdminId");

                    b.ToTable("Baristas");

                    b.HasData(
                        new
                        {
                            BaristaId = 1,
                            AdminId = 1,
                            EmailAddress = "hasandiabelharake@gmail.com",
                            FirstName = "Hasan",
                            LastName = "Ha",
                            Password = "Has123san456",
                            PhoneNumber = "12334556"
                        });
                });

            modelBuilder.Entity("MahalCoffee.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            EmailAddress = "alaadiabelharake@gmail.com",
                            FirstName = "Alaa",
                            LastName = "Diab El Harake",
                            Password = "alaa10122003",
                            PhoneNumber = "7687826"
                        });
                });

            modelBuilder.Entity("MahalCoffee.Models.Ingredients", b =>
                {
                    b.Property<int>("IngredientsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IngredientsId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IngredientsId");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            IngredientsId = 1,
                            Description = "Best Coffee i have ever taste",
                            Name = "MahalCoffee"
                        });
                });

            modelBuilder.Entity("MahalCoffee.Models.MenuView", b =>
                {
                    b.Property<int>("MenuViewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuViewId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MenuViewId");

                    b.ToTable("MenuViews");

                    b.HasData(
                        new
                        {
                            MenuViewId = 1,
                            Name = "MahalCoffee"
                        });
                });

            modelBuilder.Entity("MahalCoffee.Models.ProductIngredient", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("IngredientsId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductIngredientIngredientsId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductIngredientProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductIngredientsId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "IngredientsId");

                    b.HasIndex("IngredientsId");

                    b.HasIndex("ProductIngredientProductId", "ProductIngredientIngredientsId");

                    b.ToTable("ProductIngredients");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            IngredientsId = 1,
                            ProductIngredientsId = 0
                        });
                });

            modelBuilder.Entity("MahalCoffee.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            Comment = "Best Coffee i have ever taste",
                            CustomerId = 1,
                            Rating = 5
                        });
                });

            modelBuilder.Entity("Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int?>("BaristaId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MenuViewId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.HasIndex("BaristaId");

                    b.HasIndex("MenuViewId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            BaristaId = 1,
                            Description = "Savor the rich harmony of espresso, chocolate syrup, milk, and ice in our Mocha Frappuccino.",
                            ImageUrl = "image/pexels-luis-espinoza-11512983.jpg",
                            Name = "Mocha Frappe",
                            Price = 8.8900000000000006
                        },
                        new
                        {
                            ProductId = 2,
                            BaristaId = 1,
                            Description = "Indulge in the sweet elegance of espresso, caramel syrup, milk, and whipped cream in our Caramel Frappuccino.",
                            ImageUrl = "image/pexels-defne-ayyıldız-13263342.jpg",
                            MenuViewId = 1,
                            Name = "Caramel Frappe",
                            Price = 9.5
                        });
                });

            modelBuilder.Entity("MahalCoffee.Models.Barista", b =>
                {
                    b.HasOne("MahalCoffee.Models.Admin", "Admin")
                        .WithMany("Baristas")
                        .HasForeignKey("AdminId");

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("MahalCoffee.Models.ProductIngredient", b =>
                {
                    b.HasOne("MahalCoffee.Models.Ingredients", "ingredients")
                        .WithMany("ProductIngredients")
                        .HasForeignKey("IngredientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Product", "Product")
                        .WithMany("ProductIngredients")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MahalCoffee.Models.ProductIngredient", null)
                        .WithMany("ProductIngredients")
                        .HasForeignKey("ProductIngredientProductId", "ProductIngredientIngredientsId");

                    b.Navigation("Product");

                    b.Navigation("ingredients");
                });

            modelBuilder.Entity("MahalCoffee.Models.Review", b =>
                {
                    b.HasOne("MahalCoffee.Models.Customer", "Customer")
                        .WithMany("Reviews")
                        .HasForeignKey("CustomerId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Product", b =>
                {
                    b.HasOne("MahalCoffee.Models.Barista", "Barista")
                        .WithMany("Products")
                        .HasForeignKey("BaristaId");

                    b.HasOne("MahalCoffee.Models.MenuView", "MenuView")
                        .WithMany("Products")
                        .HasForeignKey("MenuViewId");

                    b.Navigation("Barista");

                    b.Navigation("MenuView");
                });

            modelBuilder.Entity("MahalCoffee.Models.Admin", b =>
                {
                    b.Navigation("Baristas");
                });

            modelBuilder.Entity("MahalCoffee.Models.Barista", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("MahalCoffee.Models.Customer", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("MahalCoffee.Models.Ingredients", b =>
                {
                    b.Navigation("ProductIngredients");
                });

            modelBuilder.Entity("MahalCoffee.Models.MenuView", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("MahalCoffee.Models.ProductIngredient", b =>
                {
                    b.Navigation("ProductIngredients");
                });

            modelBuilder.Entity("Product", b =>
                {
                    b.Navigation("ProductIngredients");
                });
#pragma warning restore 612, 618
        }
    }
}
