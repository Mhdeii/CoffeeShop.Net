using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MahalCoffee_CSC400.Migrations
{
    /// <inheritdoc />
    public partial class AddTablesToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    IngredientsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.IngredientsId);
                });

            migrationBuilder.CreateTable(
                name: "MenuViews",
                columns: table => new
                {
                    MenuViewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuViews", x => x.MenuViewId);
                });

            migrationBuilder.CreateTable(
                name: "Baristas",
                columns: table => new
                {
                    BaristaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baristas", x => x.BaristaId);
                    table.ForeignKey(
                        name: "FK_Baristas_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "AdminId");
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    BaristaId = table.Column<int>(type: "int", nullable: true),
                    MenuViewId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Baristas_BaristaId",
                        column: x => x.BaristaId,
                        principalTable: "Baristas",
                        principalColumn: "BaristaId");
                    table.ForeignKey(
                        name: "FK_Products_MenuViews_MenuViewId",
                        column: x => x.MenuViewId,
                        principalTable: "MenuViews",
                        principalColumn: "MenuViewId");
                });

            migrationBuilder.CreateTable(
                name: "ProductIngredients",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    IngredientsId = table.Column<int>(type: "int", nullable: false),
                    ProductIngredientsId = table.Column<int>(type: "int", nullable: false),
                    ProductIngredientIngredientsId = table.Column<int>(type: "int", nullable: true),
                    ProductIngredientProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductIngredients", x => new { x.ProductId, x.IngredientsId });
                    table.ForeignKey(
                        name: "FK_ProductIngredients_Ingredients_IngredientsId",
                        column: x => x.IngredientsId,
                        principalTable: "Ingredients",
                        principalColumn: "IngredientsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductIngredients_ProductIngredients_ProductIngredientProductId_ProductIngredientIngredientsId",
                        columns: x => new { x.ProductIngredientProductId, x.ProductIngredientIngredientsId },
                        principalTable: "ProductIngredients",
                        principalColumns: new[] { "ProductId", "IngredientsId" });
                    table.ForeignKey(
                        name: "FK_ProductIngredients_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "AdminId", "EmailAddress", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[] { 1, "alaadiabelharake@gmail.com", "Alaa", "Harake", "123456", "76878216" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "EmailAddress", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[] { 1, "alaadiabelharake@gmail.com", "Alaa", "Diab El Harake", "alaa10122003", "7687826" });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "IngredientsId", "Description", "Name" },
                values: new object[] { 1, "Best Coffee i have ever taste", "MahalCoffee" });

            migrationBuilder.InsertData(
                table: "MenuViews",
                columns: new[] { "MenuViewId", "Name" },
                values: new object[] { 1, "MahalCoffee" });

            migrationBuilder.InsertData(
                table: "Baristas",
                columns: new[] { "BaristaId", "AdminId", "EmailAddress", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[] { 1, 1, "hasandiabelharake@gmail.com", "Hasan", "Ha", "Has123san456", "12334556" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Comment", "CustomerId", "Rating" },
                values: new object[] { 1, "Best Coffee i have ever taste", 1, 5 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BaristaId", "Description", "ImageUrl", "MenuViewId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Savor the rich harmony of espresso, chocolate syrup, milk, and ice in our Mocha Frappuccino.", "image/pexels-luis-espinoza-11512983.jpg", null, "Mocha Frappe", 8.8900000000000006 },
                    { 2, 1, "Indulge in the sweet elegance of espresso, caramel syrup, milk, and whipped cream in our Caramel Frappuccino.", "image/pexels-defne-ayyıldız-13263342.jpg", 1, "Caramel Frappe", 9.5 }
                });

            migrationBuilder.InsertData(
                table: "ProductIngredients",
                columns: new[] { "IngredientsId", "ProductId", "ProductIngredientIngredientsId", "ProductIngredientProductId", "ProductIngredientsId" },
                values: new object[] { 1, 1, null, null, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Baristas_AdminId",
                table: "Baristas",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductIngredients_IngredientsId",
                table: "ProductIngredients",
                column: "IngredientsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductIngredients_ProductIngredientProductId_ProductIngredientIngredientsId",
                table: "ProductIngredients",
                columns: new[] { "ProductIngredientProductId", "ProductIngredientIngredientsId" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_BaristaId",
                table: "Products",
                column: "BaristaId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_MenuViewId",
                table: "Products",
                column: "MenuViewId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CustomerId",
                table: "Reviews",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductIngredients");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Baristas");

            migrationBuilder.DropTable(
                name: "MenuViews");

            migrationBuilder.DropTable(
                name: "Admins");
        }
    }
}
