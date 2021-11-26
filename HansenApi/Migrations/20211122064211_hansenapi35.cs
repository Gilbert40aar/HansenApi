using Microsoft.EntityFrameworkCore.Migrations;

namespace HansenApi.Migrations
{
    public partial class hansenapi35 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "opTion10",
                table: "Skills");

            migrationBuilder.AddColumn<string>(
                name: "skillsPoints",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "skillsPoints",
                table: "Skills");

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

            migrationBuilder.AddColumn<int>(
                name: "opTion10",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
