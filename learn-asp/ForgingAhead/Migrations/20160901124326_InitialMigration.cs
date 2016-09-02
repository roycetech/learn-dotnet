using Microsoft.EntityFrameworkCore.Migrations;

namespace ForgingAhead.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Quests",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quests", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    Dexterity = table.Column<int>(nullable: false),
                    Intelligence = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    QuestName = table.Column<string>(nullable: true),
                    Strength = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Characters_Quests_QuestName",
                        column: x => x.QuestName,
                        principalTable: "Quests",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_QuestName",
                table: "Characters",
                column: "QuestName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "Quests");
        }
    }
}
