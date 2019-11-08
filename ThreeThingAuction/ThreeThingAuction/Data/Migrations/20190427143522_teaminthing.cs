using Microsoft.EntityFrameworkCore.Migrations;

namespace ThreeThingAuction.Data.Migrations
{
    public partial class teaminthing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Teams_TeamID",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "TeamID",
                table: "Users",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Teamid",
                table: "Things",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Teams_TeamID",
                table: "Users",
                column: "TeamID",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Teams_TeamID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Teamid",
                table: "Things");

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
    }
}
