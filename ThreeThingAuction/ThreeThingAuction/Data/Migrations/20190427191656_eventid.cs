using Microsoft.EntityFrameworkCore.Migrations;

namespace ThreeThingAuction.Data.Migrations
{
    public partial class eventid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Things",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Things");
        }
    }
}
