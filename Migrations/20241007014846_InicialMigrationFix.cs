using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechStore.Migrations
{
    /// <inheritdoc />
    public partial class InicialMigrationFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_OrderStates_order_state_id",
                table: "orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderStates",
                table: "OrderStates");

            migrationBuilder.RenameTable(
                name: "OrderStates",
                newName: "order_state");

            migrationBuilder.AddPrimaryKey(
                name: "PK_order_state",
                table: "order_state",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_order_state_order_state_id",
                table: "orders",
                column: "order_state_id",
                principalTable: "order_state",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_order_state_order_state_id",
                table: "orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_order_state",
                table: "order_state");

            migrationBuilder.RenameTable(
                name: "order_state",
                newName: "OrderStates");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderStates",
                table: "OrderStates",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_OrderStates_order_state_id",
                table: "orders",
                column: "order_state_id",
                principalTable: "OrderStates",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
