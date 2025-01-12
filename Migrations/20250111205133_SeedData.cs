using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Electronics" },
                    { 2, "Books" },
                    { 3, "Clothing" },
                    { 4, "Home Appliances" },
                    { 5, "Toys" }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Address", "Contact", "Email", "Name", "Password" },
                values: new object[,]
                {
                    { 1, "123 Street, City", "1234567890", "alice@example.com", "Alice", "password1" },
                    { 2, "456 Avenue, City", "1234567891", "bob@example.com", "Bob", "password2" },
                    { 3, "789 Boulevard, City", "1234567892", "charlie@example.com", "Charlie", "password3" },
                    { 4, "101 Main St, City", "1234567893", "david@example.com", "David", "password4" },
                    { 5, "202 Elm St, City", "1234567894", "eve@example.com", "Eve", "password5" }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "CategoryId", "Description", "Discount", "ImageUrl", "Name", "Price", "ProductCode" },
                values: new object[,]
                {
                    { 1, 2, "Description of Product 1", 5m, "https://example.com/product1.jpg", "Product 1", 101m, "P001" },
                    { 2, 3, "Description of Product 2", 10m, "https://example.com/product2.jpg", "Product 2", 102m, "P002" },
                    { 3, 4, "Description of Product 3", 0m, "https://example.com/product3.jpg", "Product 3", 103m, "P003" },
                    { 4, 5, "Description of Product 4", 5m, "https://example.com/product4.jpg", "Product 4", 104m, "P004" },
                    { 5, 1, "Description of Product 5", 10m, "https://example.com/product5.jpg", "Product 5", 105m, "P005" },
                    { 6, 2, "Description of Product 6", 0m, "https://example.com/product6.jpg", "Product 6", 106m, "P006" },
                    { 7, 3, "Description of Product 7", 5m, "https://example.com/product7.jpg", "Product 7", 107m, "P007" },
                    { 8, 4, "Description of Product 8", 10m, "https://example.com/product8.jpg", "Product 8", 108m, "P008" },
                    { 9, 5, "Description of Product 9", 0m, "https://example.com/product9.jpg", "Product 9", 109m, "P009" },
                    { 10, 1, "Description of Product 10", 5m, "https://example.com/product10.jpg", "Product 10", 110m, "P010" },
                    { 11, 2, "Description of Product 11", 10m, "https://example.com/product11.jpg", "Product 11", 111m, "P011" },
                    { 12, 3, "Description of Product 12", 0m, "https://example.com/product12.jpg", "Product 12", 112m, "P012" },
                    { 13, 4, "Description of Product 13", 5m, "https://example.com/product13.jpg", "Product 13", 113m, "P013" },
                    { 14, 5, "Description of Product 14", 10m, "https://example.com/product14.jpg", "Product 14", 114m, "P014" },
                    { 15, 1, "Description of Product 15", 0m, "https://example.com/product15.jpg", "Product 15", 115m, "P015" },
                    { 16, 2, "Description of Product 16", 5m, "https://example.com/product16.jpg", "Product 16", 116m, "P016" },
                    { 17, 3, "Description of Product 17", 10m, "https://example.com/product17.jpg", "Product 17", 117m, "P017" },
                    { 18, 4, "Description of Product 18", 0m, "https://example.com/product18.jpg", "Product 18", 118m, "P018" },
                    { 19, 5, "Description of Product 19", 5m, "https://example.com/product19.jpg", "Product 19", 119m, "P019" },
                    { 20, 1, "Description of Product 20", 10m, "https://example.com/product20.jpg", "Product 20", 120m, "P020" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
