using Microsoft.EntityFrameworkCore.Migrations;

namespace SqlLiteLibraryPlay.Migrations
{
    public partial class AuthorToBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "books",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "books");
        }
    }
}
