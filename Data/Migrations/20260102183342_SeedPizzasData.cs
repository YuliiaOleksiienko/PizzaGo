using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PizzaGo.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedPizzasData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Traditional Italian pizza with tomato sauce, fresh mozzarella and basil.", "", "Margarita", 10.99m },
                    { 2, "Classic American favorite with spicy pepperoni slices and extra mozarella.", "", "Pepperoni", 12.99m },
                    { 3, "A rich blend of Parmesan, Gorgonzola, Cheddar, and Mozarella.", "", "Four Cheese", 13.50m },
                    { 4, "The controversial classic with juicy pineapple, ham, and tomato sauce.", "", "Hawaiian", 11.50m },
                    { 5, "Grilled chicken, red onions, and smoky BBQ sauce instead of tomato base.", "", "BBQ Chicken", 14.00m },
                    { 6, "Loaded with fresh bell peppers, mushrooms, olives, and red onions.", "", "Vegetarian", 11.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
