using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel_System_Back.Migrations
{
    /// <inheritdoc />
    public partial class UpdateConMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Clients_ClientId",
                table: "Payments");

            migrationBuilder.DropCheckConstraint(
                name: "TypeRange",
                table: "Rooms");

            migrationBuilder.AddCheckConstraint(
                name: "TypeRange",
                table: "Rooms",
                sql: "[Type] > 0 and [Type] <= 3");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Clients_ClientId",
                table: "Payments",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Clients_ClientId",
                table: "Payments");

            migrationBuilder.DropCheckConstraint(
                name: "TypeRange",
                table: "Rooms");

            migrationBuilder.AddCheckConstraint(
                name: "TypeRange",
                table: "Rooms",
                sql: "[Type] > 0 and [Type] < 3");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Clients_ClientId",
                table: "Payments",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
