using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_1.Migrations
{
    public partial class titlechange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activities",
                table: "Activityy");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Activityy",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Activityy");

            migrationBuilder.AddColumn<string>(
                name: "Activities",
                table: "Activityy",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "");
        }
    }
}
