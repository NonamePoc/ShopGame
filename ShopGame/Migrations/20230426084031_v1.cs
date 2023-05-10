using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopGame.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    client_id = table.Column<int>(type: "int", nullable: false),
                    first_name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    last_name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    phone_number = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__clients__BF21A4246CF8064C", x => x.client_id);
                });

            migrationBuilder.CreateTable(
                name: "games",
                columns: table => new
                {
                    game_id = table.Column<int>(type: "int", nullable: false),
                    title = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    genre = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    developer = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    publisher = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    release_date = table.Column<DateTime>(type: "date", nullable: true),
                    rating = table.Column<decimal>(type: "decimal(2,1)", nullable: true),
                    price = table.Column<decimal>(type: "decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__games__FFE11FCF0CBB6248", x => x.game_id);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    order_id = table.Column<int>(type: "int", nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: true),
                    order_date = table.Column<DateTime>(type: "date", nullable: true),
                    total_price = table.Column<decimal>(type: "decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__orders__46596229C8681875", x => x.order_id);
                    table.ForeignKey(
                        name: "FK__orders__client_i__4D94879B",
                        column: x => x.client_id,
                        principalTable: "clients",
                        principalColumn: "client_id");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.OrderId, x.GameId });
                    table.ForeignKey(
                        name: "FK_OrderDetails_games_GameId",
                        column: x => x.GameId,
                        principalTable: "games",
                        principalColumn: "game_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "orders",
                        principalColumn: "order_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_GameId",
                table: "OrderDetails",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_client_id",
                table: "orders",
                column: "client_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "games");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "clients");
        }
    }
}
