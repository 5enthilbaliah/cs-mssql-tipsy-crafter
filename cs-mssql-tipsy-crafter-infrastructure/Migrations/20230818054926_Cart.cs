using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmritaDb.Tipsy.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Cart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ecomm");

            migrationBuilder.CreateTable(
                name: "cart",
                schema: "ecomm",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(26)", maxLength: 26, nullable: false),
                    customer_id = table.Column<string>(type: "varchar(26)", maxLength: 26, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cart", x => x.id);
                    table.ForeignKey(
                        name: "FK_cart_customer_customer_id",
                        column: x => x.customer_id,
                        principalSchema: "retail",
                        principalTable: "customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cart_item",
                schema: "ecomm",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(26)", maxLength: 26, nullable: false),
                    cart_id = table.Column<string>(type: "varchar(26)", maxLength: 26, nullable: false),
                    product_id = table.Column<string>(type: "varchar(26)", maxLength: 26, nullable: false),
                    qty = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    msrp = table.Column<decimal>(type: "money", nullable: false, defaultValue: 0m)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cart_item", x => x.id);
                    table.ForeignKey(
                        name: "FK_cart_item_cart_cart_id",
                        column: x => x.cart_id,
                        principalSchema: "ecomm",
                        principalTable: "cart",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cart_item_product_product_id",
                        column: x => x.product_id,
                        principalSchema: "stock",
                        principalTable: "product",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cart_customer_id",
                schema: "ecomm",
                table: "cart",
                column: "customer_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cart_item_cart_id",
                schema: "ecomm",
                table: "cart_item",
                column: "cart_id");

            migrationBuilder.CreateIndex(
                name: "IX_cart_item_product_id",
                schema: "ecomm",
                table: "cart_item",
                column: "product_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cart_item",
                schema: "ecomm");

            migrationBuilder.DropTable(
                name: "cart",
                schema: "ecomm");
        }
    }
}
