using Microsoft.EntityFrameworkCore.Migrations;

namespace ThreeThingAuction.Data.Migrations
{
    public partial class UpdateTeam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Member1",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Member2",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Member3",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Member4",
                table: "Teams",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Member1",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Member2",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Member3",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Member4",
                table: "Teams");
        }
    }
}
