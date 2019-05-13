using Microsoft.EntityFrameworkCore.Migrations;

namespace ALaCart.Data.Migrations
{
    public partial class Services : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RestaurantMenuID",
                table: "Restaurants",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RestaurantMenuID",
                table: "Restaurants");
        }
    }
}
