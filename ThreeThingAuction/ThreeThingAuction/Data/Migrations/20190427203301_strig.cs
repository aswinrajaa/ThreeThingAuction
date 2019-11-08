using Microsoft.EntityFrameworkCore.Migrations;

namespace ThreeThingAuction.Data.Migrations
{
    public partial class strig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EventId",
                table: "Things",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EventId",
                table: "Things",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
