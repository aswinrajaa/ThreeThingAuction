using Microsoft.EntityFrameworkCore.Migrations;

namespace ThreeThingAuction.Data.Migrations
{
    public partial class Bidvalue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BidValue",
                table: "Things",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BidValue",
                table: "Things");
        }
    }
}
