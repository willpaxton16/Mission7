using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission7.Migrations
{
    public partial class stuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PurchaseReceived",
                table: "Purchases",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchaseReceived",
                table: "Purchases");
        }
    }
}
