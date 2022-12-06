using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CIDM3312FINALPROJECTYOTAM.B.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Checkouts",
                columns: table => new
                {
                    CheckoutID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    itemID = table.Column<int>(type: "INTEGER", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    totoalprice = table.Column<int>(name: "totoal_price", type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkouts", x => x.CheckoutID);
                });

            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    itemID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    itemname = table.Column<string>(name: "item_name", type: "TEXT", nullable: false),
                    itemprice = table.Column<int>(name: "item_price", type: "INTEGER", nullable: false),
                    itemdescription = table.Column<string>(name: "item_description", type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.itemID);
                });

            migrationBuilder.CreateTable(
                name: "carts",
                columns: table => new
                {
                    itemID = table.Column<int>(type: "INTEGER", nullable: false),
                    CheckoutID = table.Column<int>(type: "INTEGER", nullable: false),
                    quantity = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carts", x => new { x.CheckoutID, x.itemID });
                    table.ForeignKey(
                        name: "FK_carts_Checkouts_CheckoutID",
                        column: x => x.CheckoutID,
                        principalTable: "Checkouts",
                        principalColumn: "CheckoutID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_carts_items_itemID",
                        column: x => x.itemID,
                        principalTable: "items",
                        principalColumn: "itemID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_carts_itemID",
                table: "carts",
                column: "itemID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "carts");

            migrationBuilder.DropTable(
                name: "Checkouts");

            migrationBuilder.DropTable(
                name: "items");
        }
    }
}
