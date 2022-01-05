using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class SampleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "Two imprisoned", "The Shawshank Redemption" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", "The Godfather" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "The early life and career of Vito Corleone in 1920s New York is portrayed while his son, Michael, expands and tightens his grip on his crime syndicate stretching from Lake Tahoe, Nevada to pre-revolution 1958 Cuba.", "The Godfather: Part II" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 4, "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, the caped crusader must come to terms with one of the greatest psychological tests of his ability to fight injustice.", "The Dark Knight" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 5, "A look at the relationship between the life of a young", "12 Angry" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "Name" },
                values: new object[] { 1, 50, "Andy Dufresne", 1, "Tim Robbins" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "Name" },
                values: new object[] { 2, 50, "Andy Dufresne", 1, "Morgan Freeman" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "Name" },
                values: new object[] { 3, 50, "Andy Dufresne", 1, "Bob Gunton" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "Name" },
                values: new object[] { 8, 50, "Andy Dufresne", 1, "Bob Gunton" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "Name" },
                values: new object[] { 13, 50, "Andy Dufresne", 1, "Bob Gunton" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "Name" },
                values: new object[] { 4, 50, "Andy Dufresne", 2, "Bob Gunton" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "Name" },
                values: new object[] { 9, 50, "Andy Dufresne", 2, "Bob Gunton" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "Name" },
                values: new object[] { 14, 50, "Andy Dufresne", 2, "Bob Gunton" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "Name" },
                values: new object[] { 5, 50, "Andy Dufresne", 3, "Bob Gunton" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "Name" },
                values: new object[] { 10, 50, "Andy Dufresne", 3, "Bob Gunton" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "Name" },
                values: new object[] { 15, 50, "Andy Dufresne", 3, "Bob Gunton" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "Name" },
                values: new object[] { 6, 50, "Andy Dufresne", 4, "Bob Gunton" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "Name" },
                values: new object[] { 11, 50, "Andy Dufresne", 4, "Bob Gunton" });
            
            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "Name" },
                values: new object[] { 7, 50, "Andy Dufresne", 5, "Bob Gunton" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Age", "Character", "MovieId", "Name" },
                values: new object[] { 12, 50, "Andy Dufresne", 5, "Bob Gunton" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
