using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookshopMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Robert C. Martin", "A Handbook of Agile Software Craftsmanship", 35.990000000000002, "Clean Code" },
                    { 2, "Michael E. Gerber", "Why Most Small Businesses Don't Work and What to Do About It", 29.989999999999998, "The E-Myth Revisited" },
                    { 3, "Mark Hyman", "Fix Your Broken Brain by Healing Your Body First", 24.989999999999998, "The UltraMind Solution" },
                    { 4, "Sun Tzu", "An Ancient Chinese Classic on Military Strategy", 19.989999999999998, "The Art of War" },
                    { 5, "Napoleon Hill", "The Landmark Bestseller Now Revised and Updated for the 21st Century", 14.99, "Think and Grow Rich" },
                    { 6, "Dale Carnegie", "The Only Book You Need to Lead You to Success", 22.989999999999998, "How to Win Friends and Influence People" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
