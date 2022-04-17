using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroceryWebCoreApi.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeliveryDate",
                table: "Deliveries",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PickupDate",
                table: "Deliveries",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveryDate",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "PickupDate",
                table: "Deliveries");
        }
    }
}
