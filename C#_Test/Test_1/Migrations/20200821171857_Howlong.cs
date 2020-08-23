using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_1.Migrations
{
    public partial class Howlong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HowLong",
                table: "Activityy",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HowLong",
                table: "Activityy");
        }
    }
}
