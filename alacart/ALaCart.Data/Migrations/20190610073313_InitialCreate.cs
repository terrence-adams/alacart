using Microsoft.EntityFrameworkCore.Migrations;

namespace ALaCart.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b14e1727-f35b-46c0-b13a-df808aa389d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b539a25b-92af-4d38-af3a-3f2a36d737e3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e47ae53f-db77-4ac7-a39a-37099c555aa8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eedcfa69-3833-409b-81bb-ac1efe12075a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "83cd0d31-fb16-4d9b-80b3-5b44d02803f0", "bffe01a0-5cff-4a41-b231-a064cefe315e", " Admin", "ADMIN" },
                    { "1bf359c2-de68-42ba-811b-bb7b300f77dc", "44afc0f1-3604-45a4-81f4-e87b8dc21635", "User", "USER" },
                    { "52caf269-6d8f-4f59-adaa-85229fa3ee41", "0588e7c6-fc26-4557-8763-2722314a529c", "Employee", "Employee" },
                    { "1f968e6f-9790-4a68-a213-0ba6748e2be8", "9eba8397-dfba-48cf-b474-a228c193401c", "Vendor", "VENDOR" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1bf359c2-de68-42ba-811b-bb7b300f77dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f968e6f-9790-4a68-a213-0ba6748e2be8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52caf269-6d8f-4f59-adaa-85229fa3ee41");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83cd0d31-fb16-4d9b-80b3-5b44d02803f0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b14e1727-f35b-46c0-b13a-df808aa389d4", "17a78f0e-d4d9-4027-bf7d-9c32f09f0d9f", " Admin", "ADMIN" },
                    { "b539a25b-92af-4d38-af3a-3f2a36d737e3", "dcae55e6-dd25-4b5b-b44e-bdf03655e154", "User", "USER" },
                    { "eedcfa69-3833-409b-81bb-ac1efe12075a", "111e38ba-123a-4df3-9abe-2748a573f6cc", "Employee", "Employee" },
                    { "e47ae53f-db77-4ac7-a39a-37099c555aa8", "2cc82f7c-c1be-4e47-9aad-a8d740acca8d", "Vendor", "VENDOR" }
                });
        }
    }
}
