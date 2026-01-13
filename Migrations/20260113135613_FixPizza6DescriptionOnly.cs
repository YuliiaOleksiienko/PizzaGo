using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaGo.Migrations
{
    /// <inheritdoc />
    public partial class FixPizza6DescriptionOnly : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name" },
                values: new object[] { "A rustic mix of savory salami, fresh mushrooms, and black olives.", "Hunter's Pizza" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name" },
                values: new object[] { "A vegetarian delight with sliced mushrooms, black olives, and pepperoni for a salty kick.", "Mushroom & Olive" });
        }
    }
}
