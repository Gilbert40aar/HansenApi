using Microsoft.EntityFrameworkCore.Migrations;

namespace HansenApi.Migrations
{
    public partial class hansenapi2223 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_SkillOptions_skillOptionsId",
                table: "Skills");

            migrationBuilder.DropTable(
                name: "SkillOptions");

            migrationBuilder.DropIndex(
                name: "IX_Skills_skillOptionsId",
                table: "Skills");

            migrationBuilder.RenameColumn(
                name: "skillOptionsId",
                table: "Skills",
                newName: "opTion10");

            migrationBuilder.AddColumn<int>(
                name: "opTion01",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "opTion02",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "opTion03",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "opTion04",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "opTion05",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "opTion06",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "opTion07",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "opTion08",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "opTion09",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "opTion01",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "opTion02",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "opTion03",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "opTion04",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "opTion05",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "opTion06",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "opTion07",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "opTion08",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "opTion09",
                table: "Skills");

            migrationBuilder.RenameColumn(
                name: "opTion10",
                table: "Skills",
                newName: "skillOptionsId");

            migrationBuilder.CreateTable(
                name: "SkillOptions",
                columns: table => new
                {
                    skillOptionsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    opTion01 = table.Column<int>(type: "int", nullable: false),
                    opTion02 = table.Column<int>(type: "int", nullable: false),
                    opTion03 = table.Column<int>(type: "int", nullable: false),
                    opTion04 = table.Column<int>(type: "int", nullable: false),
                    opTion05 = table.Column<int>(type: "int", nullable: false),
                    opTion06 = table.Column<int>(type: "int", nullable: false),
                    opTion07 = table.Column<int>(type: "int", nullable: false),
                    opTion08 = table.Column<int>(type: "int", nullable: false),
                    opTion09 = table.Column<int>(type: "int", nullable: false),
                    opTion10 = table.Column<int>(type: "int", nullable: false),
                    skillId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillOptions", x => x.skillOptionsId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Skills_skillOptionsId",
                table: "Skills",
                column: "skillOptionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_SkillOptions_skillOptionsId",
                table: "Skills",
                column: "skillOptionsId",
                principalTable: "SkillOptions",
                principalColumn: "skillOptionsId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
