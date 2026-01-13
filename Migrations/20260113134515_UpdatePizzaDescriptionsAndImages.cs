using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaGo.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePizzaDescriptionsAndImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "A hearty pizza loaded with ground beef and extra melted mozzarella on a thick crust.", "/images/pizzas/foad-roshan-nDlXtnzsD5o-unsplash.jpg", "Cheesy Meat", 13.99m });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Sweet pineapple chunks, savory ham, and crispy bacon bits over a rich tomato base.", "/images/pizzas/heather-barnes-YKvGUO4Zb7Y-unsplash.jpg", "Tropical Feast", 12.50m });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Juicy grilled chicken pieces mixed with fresh green bell peppers and aromatic herbs.", "/images/pizzas/rizwan-ahmed-E38gYohvCGs-unsplash.jpg", "Chicken & Pepper", 14.00m });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Traditional thin-crust pizza topped with generous layers of spicy pepperoni and cheese.", "/images/pizzas/pexels-polina-tankilevitch-4109085.jpg", "Classic Pepperoni", 11.99m });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "For those who like it hot: premium spicy salami with double cheese and a smokey finish.", "/images/pizzas/foad-roshan-JOYjHvOTFJQ-unsplash.jpg", "Spicy Salami", 13.50m });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "A vegetarian delight with sliced mushrooms, black olives, and pepperoni for a salty kick.", "/images/pizzas/pexels-roman-odintsov-5903178.jpg", "Mushroom & Olive", 12.00m });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Savory beef slices paired with forest mushrooms and creamy mozzarella cheese.", "/images/pizzas/foad-roshan-QRUFgHHd2F8-unsplash.jpg", "Beef & Mushroom" });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Fresh basil leaves and crispy pepperoni slices on a zesty tomato and garlic sauce.", "/images/pizzas/mike-cox-dlctifSsn_8-unsplash.jpg", "Pepperoni Basil" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Traditional Italian pizza with tomato sauce, fresh mozzarella and basil.", "", "Margarita", 10.99m });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Classic American favorite with spicy pepperoni slices and extra mozarella.", "", "Pepperoni", 12.99m });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "A rich blend of Parmesan, Gorgonzola, Cheddar, and Mozarella.", "", "Four Cheese", 13.50m });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "The controversial classic with juicy pineapple, ham, and tomato sauce.", "", "Hawaiian", 11.50m });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Grilled chicken, red onions, and smoky BBQ sauce instead of tomato base.", "", "BBQ Chicken", 14.00m });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Loaded with fresh bell peppers, mushrooms, olives, and red onions.", "", "Vegetarian", 11.00m });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Combination of mozzarella, gorgonzola, parmesan, and fontina.", "", "Quattro Formaggi" });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageUrl", "Name" },
                values: new object[] { "Classic Italian pizza with mozzarella, ham, mushrooms and artichokes.", "", "Capricciosa" });
        }
    }
}
