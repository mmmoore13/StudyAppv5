using Microsoft.EntityFrameworkCore.Migrations;

namespace StudyAppV2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Study",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Discriminator = table.Column<string>(nullable: false),
                    Answers = table.Column<string>(nullable: true),
                    Questions = table.Column<string>(nullable: true),
                    Definitions = table.Column<string>(nullable: true),
                    Terms = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Study", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Study");
        }
    }
}
