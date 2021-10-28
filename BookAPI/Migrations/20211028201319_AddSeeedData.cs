using Microsoft.EntityFrameworkCore.Migrations;

namespace BookAPI.Migrations
{
    public partial class AddSeeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Genre", "Rating", "Read", "Title" },
                values: new object[,]
                {
                    { 1, "J. K. Rowling", "Fantasy", 8, true, "Harry Potter" },
                    { 2, "Alex Michaelides", "Thriller", 5, false, "The Silent Patient" },
                    { 3, "Philip K. Dick", "Sci-Fi", 8, true, "Do Androids Dream of Electric Sheep" },
                    { 4, "Rachel Carson", "Non-Fiction", 8, true, "Silent Spring" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);
        }
    }
}
