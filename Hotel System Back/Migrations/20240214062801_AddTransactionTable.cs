using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel_System_Back.Migrations
{
    /// <inheritdoc />
    public partial class AddTransactionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "NidValidation1",
                table: "Employees");

            migrationBuilder.DropCheckConstraint(
                name: "NidValidation",
                table: "Clients");

            migrationBuilder.CreateTable(
                name: "TransactionTable",
                columns: table => new
                {
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    RoomNumber = table.Column<int>(type: "int", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    Paid = table.Column<float>(type: "real", nullable: false),
                    Rest = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.AddCheckConstraint(
                name: "NidValidation1",
                table: "Employees",
                sql: "len([NId]) = 14 and [NId] not like '%[a-zA-Z.+/*_]%'");

            migrationBuilder.AddCheckConstraint(
                name: "NidValidation",
                table: "Clients",
                sql: "len([NId]) = 14 and [NId] not like '%[a-zA-Z.+/*_]%'");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransactionTable");

            migrationBuilder.DropCheckConstraint(
                name: "NidValidation1",
                table: "Employees");

            migrationBuilder.DropCheckConstraint(
                name: "NidValidation",
                table: "Clients");

            migrationBuilder.AddCheckConstraint(
                name: "NidValidation1",
                table: "Employees",
                sql: "len([NId]) = 14");

            migrationBuilder.AddCheckConstraint(
                name: "NidValidation",
                table: "Clients",
                sql: "len([NId]) = 14");
        }
    }
}
