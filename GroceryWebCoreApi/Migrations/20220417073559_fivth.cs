using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroceryWebCoreApi.Migrations
{
    public partial class fivth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DeliveryDate",
                table: "Orders",
                newName: "OrderDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderDate",
                table: "Orders",
                newName: "DeliveryDate");
        }
    }
}
