using Microsoft.EntityFrameworkCore.Migrations;

namespace Final.Migrations
{
    public partial class Initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Book_image = table.Column<string>(nullable: false),
                    Book_type = table.Column<string>(nullable: false),
                    Book_name = table.Column<string>(maxLength: 50, nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    Author = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
