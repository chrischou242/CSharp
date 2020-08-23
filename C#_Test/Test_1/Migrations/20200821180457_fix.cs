using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_1.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activityy_Users_UserId",
                table: "Activityy");

            migrationBuilder.DropForeignKey(
                name: "FK_Join_Activityy_ActivitiesId",
                table: "Join");

            migrationBuilder.DropForeignKey(
                name: "FK_Join_Users_UserId",
                table: "Join");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Join",
                table: "Join");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Activityy",
                table: "Activityy");

            migrationBuilder.RenameTable(
                name: "Join",
                newName: "Joins");

            migrationBuilder.RenameTable(
                name: "Activityy",
                newName: "Activities");

            migrationBuilder.RenameIndex(
                name: "IX_Join_UserId",
                table: "Joins",
                newName: "IX_Joins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Join_ActivitiesId",
                table: "Joins",
                newName: "IX_Joins_ActivitiesId");

            migrationBuilder.RenameIndex(
                name: "IX_Activityy_UserId",
                table: "Activities",
                newName: "IX_Activities_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Joins",
                table: "Joins",
                column: "JoinId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Activities",
                table: "Activities",
                column: "ActivityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Users_UserId",
                table: "Activities",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Joins_Activities_ActivitiesId",
                table: "Joins",
                column: "ActivitiesId",
                principalTable: "Activities",
                principalColumn: "ActivityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Joins_Users_UserId",
                table: "Joins",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Users_UserId",
                table: "Activities");

            migrationBuilder.DropForeignKey(
                name: "FK_Joins_Activities_ActivitiesId",
                table: "Joins");

            migrationBuilder.DropForeignKey(
                name: "FK_Joins_Users_UserId",
                table: "Joins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Joins",
                table: "Joins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Activities",
                table: "Activities");

            migrationBuilder.RenameTable(
                name: "Joins",
                newName: "Join");

            migrationBuilder.RenameTable(
                name: "Activities",
                newName: "Activityy");

            migrationBuilder.RenameIndex(
                name: "IX_Joins_UserId",
                table: "Join",
                newName: "IX_Join_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Joins_ActivitiesId",
                table: "Join",
                newName: "IX_Join_ActivitiesId");

            migrationBuilder.RenameIndex(
                name: "IX_Activities_UserId",
                table: "Activityy",
                newName: "IX_Activityy_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Join",
                table: "Join",
                column: "JoinId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Activityy",
                table: "Activityy",
                column: "ActivityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activityy_Users_UserId",
                table: "Activityy",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Join_Activityy_ActivitiesId",
                table: "Join",
                column: "ActivitiesId",
                principalTable: "Activityy",
                principalColumn: "ActivityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Join_Users_UserId",
                table: "Join",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
