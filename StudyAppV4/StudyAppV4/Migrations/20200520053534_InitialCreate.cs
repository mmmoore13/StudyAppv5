using Microsoft.EntityFrameworkCore.Migrations;

namespace StudyAppV4.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Term",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Subject = table.Column<string>(nullable: true),
                    Terms = table.Column<string>(nullable: true),
                    Definitions = table.Column<string>(nullable: true),
                    Questions = table.Column<string>(nullable: true),
                    Answers = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Term", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Term");
        }
    }
}
