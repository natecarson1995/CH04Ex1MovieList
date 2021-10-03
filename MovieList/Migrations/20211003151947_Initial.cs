using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieList.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Name", "Rating", "Year" },
                values: new object[] { 1, "Dear Evan Hansen", 2, 2021 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Name", "Rating", "Year" },
                values: new object[] { 2, "Malignant", 4, 2021 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Name", "Rating", "Year" },
                values: new object[] { 3, "Cry Macho", 3, 2021 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
