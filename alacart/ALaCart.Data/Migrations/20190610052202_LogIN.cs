using Microsoft.EntityFrameworkCore.Migrations;

namespace ALaCart.Data.Migrations
{
    public partial class LogIN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Address_CustomerAddressID",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerAddressID",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Address_CustomerAddressID",
                table: "AspNetUsers",
                column: "CustomerAddressID",
                principalTable: "Address",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Address_CustomerAddressID",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerAddressID",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Address_CustomerAddressID",
                table: "AspNetUsers",
                column: "CustomerAddressID",
                principalTable: "Address",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
