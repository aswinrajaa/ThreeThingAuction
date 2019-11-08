using Microsoft.EntityFrameworkCore.Migrations;

namespace ThreeThingAuction.Data.Migrations
{
    public partial class Teamid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Teams_TeamId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "Users",
                newName: "TeamID");

            migrationBuilder.RenameIndex(
                name: "IX_Users_TeamId",
                table: "Users",
                newName: "IX_Users_TeamID");

            migrationBuilder.AlterColumn<int>(
                name: "TeamID",
                table: "Users",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Teams_TeamID",
                table: "Users",
                column: "TeamID",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Teams_TeamID",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "TeamID",
                table: "Users",
                newName: "TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_TeamID",
                table: "Users",
                newName: "IX_Users_TeamId");

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "Users",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Teams_TeamId",
                table: "Users",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
