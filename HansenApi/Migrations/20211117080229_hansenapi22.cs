using Microsoft.EntityFrameworkCore.Migrations;

namespace HansenApi.Migrations
{
    public partial class hansenapi22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "courses",
                table: "Education",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "internship",
                table: "Education",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "courses",
                table: "Education");

            migrationBuilder.DropColumn(
                name: "internship",
                table: "Education");
        }
    }
}
