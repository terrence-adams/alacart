using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ALaCart.Data.Migrations
{
    public partial class DbContextAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menu_Restaurants_RestaurantID",
                table: "Menu");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuItem_Menu_MenuID",
                table: "MenuItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MenuItem",
                table: "MenuItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Menu",
                table: "Menu");

            migrationBuilder.RenameTable(
                name: "MenuItem",
                newName: "MenuItems");

            migrationBuilder.RenameTable(
                name: "Menu",
                newName: "Menus");

            migrationBuilder.RenameIndex(
                name: "IX_MenuItem_MenuID",
                table: "MenuItems",
                newName: "IX_MenuItems_MenuID");

            migrationBuilder.RenameColumn(
                name: "RestaurantID",
                table: "Menus",
                newName: "RestaurantOfMenuID");

            migrationBuilder.RenameIndex(
                name: "IX_Menu_RestaurantID",
                table: "Menus",
                newName: "IX_Menus_RestaurantOfMenuID");

            migrationBuilder.AddColumn<int>(
                name: "SiteID",
                table: "Restaurants",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RestaurantIdOfMenu",
                table: "Menus",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MenuItems",
                table: "MenuItems",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Menus",
                table: "Menus",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address1 = table.Column<string>(maxLength: 50, nullable: false),
                    Address2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(maxLength: 30, nullable: false),
                    State = table.Column<string>(nullable: false),
                    Zipcode = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sites",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SiteName = table.Column<string>(nullable: false),
                    SiteAddressID = table.Column<int>(nullable: true),
                    RestaurantID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sites", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sites_Address_SiteAddressID",
                        column: x => x.SiteAddressID,
                        principalTable: "Address",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SiteID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cart_Sites_SiteID",
                        column: x => x.SiteID,
                        principalTable: "Sites",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 30, nullable: false),
                    EmailAddress = table.Column<string>(maxLength: 30, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 10, nullable: false),
                    CustomerCartID = table.Column<int>(nullable: true),
                    CustomerAddressID = table.Column<int>(nullable: true),
                    SiteID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Customer_Address_CustomerAddressID",
                        column: x => x.CustomerAddressID,
                        principalTable: "Address",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_Cart_CustomerCartID",
                        column: x => x.CustomerCartID,
                        principalTable: "Cart",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_Sites_SiteID",
                        column: x => x.SiteID,
                        principalTable: "Sites",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "ID", "Description", "Name", "RestaurantMenuID", "SiteID" },
                values: new object[,]
                {
                    { 1, "Soul food", "Old Hubbards", 0, null },
                    { 2, "Classic burgers and shakes.", "Billy Ray's Burgers", 0, null },
                    { 3, "Traditional Thai food with a twist", "Thai-phun", 0, null },
                    { 4, " Your mama's chicken, served to go.", " Chicken Matters", 0, null },
                    { 5, " Delicious Vegan and Veggie options", " Vegans 4 Life", 0, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_SiteID",
                table: "Restaurants",
                column: "SiteID");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_SiteID",
                table: "Cart",
                column: "SiteID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CustomerAddressID",
                table: "Customer",
                column: "CustomerAddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CustomerCartID",
                table: "Customer",
                column: "CustomerCartID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_SiteID",
                table: "Customer",
                column: "SiteID");

            migrationBuilder.CreateIndex(
                name: "IX_Sites_SiteAddressID",
                table: "Sites",
                column: "SiteAddressID");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItems_Menus_MenuID",
                table: "MenuItems",
                column: "MenuID",
                principalTable: "Menus",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Restaurants_RestaurantOfMenuID",
                table: "Menus",
                column: "RestaurantOfMenuID",
                principalTable: "Restaurants",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_Sites_SiteID",
                table: "Restaurants",
                column: "SiteID",
                principalTable: "Sites",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuItems_Menus_MenuID",
                table: "MenuItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Restaurants_RestaurantOfMenuID",
                table: "Menus");

            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_Sites_SiteID",
                table: "Restaurants");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Sites");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Restaurants_SiteID",
                table: "Restaurants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Menus",
                table: "Menus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MenuItems",
                table: "MenuItems");

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "SiteID",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "RestaurantIdOfMenu",
                table: "Menus");

            migrationBuilder.RenameTable(
                name: "Menus",
                newName: "Menu");

            migrationBuilder.RenameTable(
                name: "MenuItems",
                newName: "MenuItem");

            migrationBuilder.RenameColumn(
                name: "RestaurantOfMenuID",
                table: "Menu",
                newName: "RestaurantID");

            migrationBuilder.RenameIndex(
                name: "IX_Menus_RestaurantOfMenuID",
                table: "Menu",
                newName: "IX_Menu_RestaurantID");

            migrationBuilder.RenameIndex(
                name: "IX_MenuItems_MenuID",
                table: "MenuItem",
                newName: "IX_MenuItem_MenuID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Menu",
                table: "Menu",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MenuItem",
                table: "MenuItem",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Menu_Restaurants_RestaurantID",
                table: "Menu",
                column: "RestaurantID",
                principalTable: "Restaurants",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItem_Menu_MenuID",
                table: "MenuItem",
                column: "MenuID",
                principalTable: "Menu",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
