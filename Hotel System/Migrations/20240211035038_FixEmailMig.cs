using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel_System.Migrations
{
    /// <inheritdoc />
    public partial class FixEmailMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "EmailValidation1",
                table: "Employees");

            migrationBuilder.DropCheckConstraint(
                name: "EmailValidation",
                table: "Clients");

            migrationBuilder.AddCheckConstraint(
                name: "EmailValidation1",
                table: "Employees",
                sql: "[Email] like '%[a-zA-z0-9.]@__%.__%' and [Email] not like '%[-+/*]%'");

            migrationBuilder.AddCheckConstraint(
                name: "EmailValidation",
                table: "Clients",
                sql: "[Email] like '%[a-zA-z0-9.]@__%.__%' and [Email] not like '%[-+/*]%'");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "EmailValidation1",
                table: "Employees");

            migrationBuilder.DropCheckConstraint(
                name: "EmailValidation",
                table: "Clients");

            migrationBuilder.AddCheckConstraint(
                name: "EmailValidation1",
                table: "Employees",
                sql: "[Email] like '[A-Za-z0-9+_.-]+@ (.+)$'");

            migrationBuilder.AddCheckConstraint(
                name: "EmailValidation",
                table: "Clients",
                sql: "[Email] like '[A-Za-z0-9+_.-]+@ (.+)$'");
        }
    }
}
